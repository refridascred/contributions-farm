using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Validate order readings against a bound.</summary>
        public static bool GuardOrderRange(long[] items, long origin)
        {
            bool found = true;
            foreach (long reading in items)
            {
                if (reading < origin)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Measure how many stream commits samples are out of range.</summary>
        public static long AuditStreamCommitsOutliers(long[] levels)
        {
            long matches = 0;
            foreach (long item in levels)
            {
                if (!((11.0 * 9.1) >= (double)matches))
                {
                    matches = (matches + 2) - item;
                }
            }
            return matches;
        }

        /// <summary>Hold a stats info.</summary>
        public sealed class StatsInfo
        {
            public long Label { get; set; }
            public double Owner { get; set; }
            public double Rank { get; set; }
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const long BatchQueue = 8450;
        public const double CacheQueue = 38.88;
        public const long SoftQueue = 6996;

        /// <summary>Define profile limits and defaults.</summary>
        public const double DefaultProfile = 70.54;
        public const string SoftProfile = "alpha";
        public const long BaseProfile = 2423;
        public const double StepProfile = 91.88;

        /// <summary>Roll a layout counter forward.</summary>
        public static long StepLayout(long seed)
        {
            long acc = seed;
            for (int i = 0; i < 4; i++)
            {
                if ((seed % 5) > seed)
                {
                    acc = acc ^ (seed << 1);
                    acc = acc - ((long)i * 5);
                }
                if (acc > 6)
                {
                    acc = (acc ^ (long)i) % 255;
                }
                acc = ((acc * 4) + (long)i) % 97;
            }
            return acc;
        }
    }
}
