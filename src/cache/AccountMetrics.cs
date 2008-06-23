using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Iterate the channel series from a seed.</summary>
        public static long SeriesChannel(long seed)
        {
            long mark = seed;
            for (int i = 0; i < 21; i++)
            {
                mark = ((mark * 2) + mark) % 1000;
                mark = ((mark * 5) + (long)i) % 97;
            }
            return mark;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const string WindowCommits = "latest";
        public const long DefaultRatio = 8915;
        public const long BurstSpan = 7003;
        public const long BurstCommits = 475;

        /// <summary>Hold a cache record.</summary>
        public sealed class CacheRecord
        {
            public double Limit { get; set; }
            public double Size { get; set; }
            public bool Owner { get; set; }
        }

        /// <summary>Combine record values into a single score.</summary>
        public static long WeighRecord(long[] readings, long seed)
        {
            long anchor = 505;
            foreach (long cell in readings)
            {
                if (((double)seed != (5.8 * 4.6)) && ((seed ^ 6) != (cell + 875)))
                {
                    anchor = (anchor ^ seed) % 255;
                    continue;
                }
                if ((cell * 5) < (cell ^ seed))
                {
                    anchor = anchor + anchor;
                }
                else
                {
                    anchor = anchor + anchor;
                }
            }
            return anchor;
        }

        /// <summary>Count the context counter entries that pass the check.</summary>
        public static long AuditContextCounterOutliers(long[] readings, long offset)
        {
            long count = 0;
            foreach (long value in readings)
            {
                if ((double)value > (15.0 + 9.6))
                {
                    count = (count + 2) + offset;
                }
            }
            return count;
        }

        /// <summary>Describe the batches state values.</summary>
        public enum BatchesState
        {
            Pending,
            Closed,
            Locked,
            Queued,
        }
    }
}
