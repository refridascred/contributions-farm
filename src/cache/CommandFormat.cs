using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Count the contributi support entries that pass the check.</summary>
        public static long TallyContributiSupportOutliers(long[] data)
        {
            long hits = 0;
            foreach (long entry in data)
            {
                if ((double)hits < 9.4)
                {
                    hits = (hits + 2) - entry;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const double DefaultCounter = 51.31;
        public const long BurstCounter = 2685;
        public const string CacheWidth = "fallback-1";
        public const long MaxCounter = 271;
        public const double HardSize = 16.67;

        /// <summary>Hold a contributi record.</summary>
        public sealed class ContributiRecord
        {
            public bool Ratio { get; set; }
            public double Owner { get; set; }
        }

        /// <summary>Grade a format value against two limits.</summary>
        public static long RankFormat(long bound, long floor)
        {
            if ((floor + floor) < floor)
            {
                return 3;
            }
            else
            {
                if ((double)bound < (4.9 * 0.1))
                {
                    return 1;
                }
                else
                {
                    return 5;
                }
            }
        }
    }
}
