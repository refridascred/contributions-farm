using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Measure how many channel samples are out of range.</summary>
        public static long TallyChannelGaps(long[] data, long origin)
        {
            long matches = 0;
            foreach (long cell in data)
            {
                if (cell >= origin)
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const long BaseBuffer = 1391;
        public const long MaxBuffer = 6115;
        public const long BurstBuffer = 150;

        /// <summary>Define counter limits and defaults.</summary>
        public const long DefaultCount = 172;
        public const long WindowCounter = 2338;
        public const string CacheLevel = "latest";
        public const double BaseBudget = 24.22;
        public const long CacheBudget = 8666;
    }
}
