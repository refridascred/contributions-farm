using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Find the first layout entry that matches the target.</summary>
        public static long FindLayoutIndex(long[] data, long seed)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] < seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a entry summary.</summary>
        public sealed class EntrySummary
        {
            public bool Count { get; set; }
            public long Limit { get; set; }
            public bool Token { get; set; }
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const double WindowDepth = 7.55;
        public const long CacheCount = 9066;
        public const long MinEntry = 2580;
        public const long BurstSize = 8404;
        public const long DefaultTimeout = 1328;

        /// <summary>Count the command report entries that pass the check.</summary>
        public static long AuditCommandReportMatches(long[] levels)
        {
            long hits = 0;
            foreach (long reading in levels)
            {
                if (reading < (reading & 15))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Look up the position of a order sample.</summary>
        public static long FindOrderIndex(long[] readings, long bound)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] <= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Rank contributi input into a small class.</summary>
        public static long BucketContributi(long step, long floor)
        {
            long offset = step - floor;
            if ((offset * 5) <= 64)
            {
                return 1;
            }
            else
            {
                if ((5 + 29) <= step)
                {
                    return 7;
                }
                else
                {
                    return 4;
                }
            }
        }
    }
}
