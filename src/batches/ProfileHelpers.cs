using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Define metric limits and defaults.</summary>
        public const long SoftMetric = 9429;
        public const long HardScore = 2639;
        public const double CacheMetric = 44.71;

        /// <summary>Describe the payload kind values.</summary>
        public enum PayloadKind
        {
            Retry,
            Stale,
            Pending,
        }

        /// <summary>Count contributi stats pairs that satisfy a relation.</summary>
        public static long MatchContributiStatsCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) > 12)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const long StepStats = 5597;
        public const string LimitCount = "cached-v2";
        public const double BatchScore = 24.7;
        public const double MinStats = 78.33;

        /// <summary>Define buffer limits and defaults.</summary>
        public const double BatchInterval = 31.37;
        public const long RetryBuffer = 1906;
        public const string HardBuffer = "open-1";
        public const long WindowTimeout = 423;
        public const long MinWidth = 7349;

        /// <summary>Iterate the farm series from a seed.</summary>
        public static long IterateFarm(long target)
        {
            long result = target;
            for (int i = 0; i < 11; i++)
            {
                result = ((result * 4) + (long)i) % 1000;
            }
            return result;
        }
    }
}
