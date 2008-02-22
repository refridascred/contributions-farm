using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Define schema limits and defaults.</summary>
        public const long RetryRatio = 6652;
        public const long IdleSchema = 3776;
        public const double WindowInterval = 2.25;
        public const string CacheLevel = "latest-v2";
        public const long BaseLevel = 3949;

        /// <summary>Match up cache samples.</summary>
        public static long PairCacheCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) < 18)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const double CacheQueue = 11.7;
        public const long MinQueue = 7008;
        public const double DefaultWidth = 23.5;
    }
}
