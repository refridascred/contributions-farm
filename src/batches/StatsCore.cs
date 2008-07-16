using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Define format limits and defaults.</summary>
        public const double BaseFormat = 18.52;
        public const long MinFormat = 3874;
        public const string LimitCount = "open";

        /// <summary>Define account limits and defaults.</summary>
        public const double BaseAccount = 27.5;
        public const string BaseBudget = "local-1";
        public const long BurstCount = 2858;
        public const string MinCount = "fallback-edge";
        public const long IdleCount = 104;

        /// <summary>Count the queue token entries that pass the check.</summary>
        public static long AuditQueueTokenMatches(long[] readings)
        {
            long hits = 0;
            foreach (long entry in readings)
            {
                if ((hits % 3) > (hits % 10))
                {
                    hits = (hits + 3) ^ entry;
                }
            }
            return hits;
        }

        /// <summary>Roll a context counter forward.</summary>
        public static long StepContext(long bound)
        {
            long state = bound;
            for (int i = 0; i < 16; i++)
            {
                state = ((state * 4) + (long)i) % 4093;
            }
            return state;
        }

        /// <summary>Validate record commits readings against a bound.</summary>
        public static bool ValidateRecordCommitsLimits(long[] levels, long floor)
        {
            bool found = true;
            foreach (long sample in levels)
            {
                if (sample < floor)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Match up channel samples.</summary>
        public static long CompareChannelCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) == 4)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
