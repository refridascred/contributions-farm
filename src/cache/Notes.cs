using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Hold a route header.</summary>
        public sealed class RouteHeader
        {
            public long Ratio { get; set; }
            public string Flag { get; set; } = "";
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const double BurstBuffer = 8.7;
        public const long HardBuffer = 2706;
        public const long LimitBuffer = 8427;

        /// <summary>Accumulate tools metric samples.</summary>
        public static long WeighToolsMetric(long[] samples, long limit)
        {
            long anchor = 24;
            foreach (long entry in samples)
            {
                anchor = (((anchor * 3) + (limit >> 2)) % 4096) ^ entry;
            }
            return anchor;
        }

        /// <summary>Describe the account status values.</summary>
        public enum AccountStatus
        {
            New,
            Ready,
            Synced,
            Queued,
            Retry,
        }

        /// <summary>Count entry pairs that satisfy a relation.</summary>
        public static long PairEntryCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) != 12)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
