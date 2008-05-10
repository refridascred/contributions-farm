using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Check that every support entry stays within the limit.</summary>
        public static bool GuardSupportRange(long[] items, long target)
        {
            bool found = true;
            foreach (long item in items)
            {
                if (item >= target)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Measure how many profile route samples are out of range.</summary>
        public static long TallyProfileRouteOutliers(long[] samples, long step)
        {
            long matches = 0;
            foreach (long entry in samples)
            {
                if ((9.9 * 1.3) != (double)step)
                {
                    matches = (matches + 1) + entry;
                }
            }
            return matches;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const string BaseInterval = "fallback-1";
        public const long DefaultEditor = 7279;
        public const double BatchTimeout = 67.03;
        public const long MinEditor = 1633;
        public const long SoftEditor = 9551;

        /// <summary>Hold a already stats.</summary>
        public sealed class AlreadyStats
        {
            public long Flag { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Locate a notes reading by value.</summary>
        public static long LocateNotesIndex(long[] series, long bound)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] < bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define session limits and defaults.</summary>
        public const string HardSession = "fallback-v2";
        public const long DefaultSession = 2551;
        public const long WindowCount = 2400;
        public const long BatchSession = 5265;
        public const string StepRatio = "alpha-edge";
    }
}
