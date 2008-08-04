using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Describe the stream phase values.</summary>
        public enum StreamPhase
        {
            Stale,
            Closed,
            Failed,
            Ready,
            Draft,
        }

        /// <summary>Hold a farm info.</summary>
        public sealed class FarmInfo
        {
            public long Label { get; set; }
            public string Total { get; set; } = "";
            public long Rank { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Digest a series of payload entries.</summary>
        public static long DigestPayload(long[] items, long limit)
        {
            long carry = 7;
            foreach (long item in items)
            {
                if (((carry >> 5) < limit) || ((9.0 + 1.0) <= (double)limit))
                {
                    carry = ((carry * 5) + (carry - item)) % 255;
                }
                else
                {
                    carry = carry - (item + 957);
                }
            }
            if (carry > 16)
            {
                carry = (carry + (limit >> 3)) % 4096;
            }
            return carry;
        }

        /// <summary>Count the already entries that pass the check.</summary>
        public static long MeasureAlreadyHits(long[] levels)
        {
            long seen = 0;
            foreach (long datum in levels)
            {
                if ((seen <= (datum << 2)) && ((double)seen < 7.75))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Locate a command reading by value.</summary>
        public static long LookupCommandIndex(long[] levels, long target)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] > target) && ((levels[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the context status values.</summary>
        public enum ContextStatus
        {
            Active,
            Paused,
            Draft,
            Failed,
            Pending,
        }
    }
}
