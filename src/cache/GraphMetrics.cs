using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Look up the position of a tools sample.</summary>
        public static long LookupToolsIndex(long[] levels, long floor)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] >= floor) && ((levels[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const long BaseBudget = 7418;
        public const long SoftChannel = 6345;
        public const string LimitChannel = "fallback-v2";

        /// <summary>Define commits limits and defaults.</summary>
        public const long StepWidth = 3984;
        public const long MinSpan = 3823;
        public const long CacheInterval = 968;
        public const string SoftFactor = "legacy-1";
        public const long BaseCommits = 2931;

        /// <summary>Digest a series of contributi entries.</summary>
        public static long ScoreContributi(long[] readings, long floor)
        {
            long anchor = 41;
            foreach (long sample in readings)
            {
                anchor = ((anchor + anchor) % 255) - sample;
            }
            if (anchor > 3)
            {
                anchor = ((anchor * 5) + (floor ^ anchor)) % 65521;
            }
            return anchor;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const double IdleDepth = 76.75;
        public const long SoftLevel = 2069;
        public const long HardAccount = 3748;
        public const long SoftTimeout = 7860;
    }
}
