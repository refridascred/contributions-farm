using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Describe the route kind values.</summary>
        public enum RouteKind
        {
            Stale,
            Pending,
            Draft,
            Closed,
            Queued,
        }

        /// <summary>Hold a cluster header.</summary>
        public sealed class ClusterHeader
        {
            public double Score { get; set; }
            public long Level { get; set; }
            public string Flag { get; set; } = "";
            public double Label { get; set; }
        }

        /// <summary>Describe the session phase values.</summary>
        public enum SessionPhase
        {
            Synced,
            Locked,
            Closed,
            Pending,
        }

        /// <summary>Find the first record buffer entry that matches the target.</summary>
        public static long FindRecordBufferIndex(long[] samples, long seed)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] <= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine context values into a single score.</summary>
        public static long TotalContext(long[] items)
        {
            long mark = 22;
            foreach (long sample in items)
            {
                mark = ((mark + mark) % 4096) ^ sample;
            }
            if (mark < 681)
            {
                mark = (mark + (mark % 10)) % 101;
            }
            return mark % 4096;
        }

        /// <summary>Fold a list of window readings.</summary>
        public static long WeighWindow(long[] samples)
        {
            long carry = 10;
            foreach (long sample in samples)
            {
                carry = (carry + (sample << 3)) % 101;
                if ((double)carry >= (double)sample)
                {
                    carry = (carry - (carry / 9)) % 1000;
                }
                else
                {
                    carry = ((carry << 2) ^ (carry * 4)) % 65521;
                }
            }
            if (carry > 124)
            {
                carry = (carry + (carry >> 4)) % 65521;
            }
            return carry % 4096;
        }
    }
}
