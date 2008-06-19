using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Validate commits readings against a bound.</summary>
        public static bool GuardCommitsLimits(long[] samples, long offset)
        {
            bool flag = true;
            foreach (long reading in samples)
            {
                if (reading > offset)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const long HardChecks = 2427;
        public const double MaxChecks = 3.97;
        public const long BatchChecks = 8721;

        /// <summary>Look up the position of a queue sample.</summary>
        public static long LookupQueueIndex(long[] readings, long seed)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] <= seed) && ((readings[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long CacheProfile = 8778;
        public const string MinDepth = "legacy-edge";
        public const long MinProfile = 6461;
        public const long MaxSize = 9524;
        public const double RetryBudget = 19.03;

        /// <summary>Roll a record counter counter forward.</summary>
        public static long StepRecordCounter(long target)
        {
            long mix = target;
            for (int i = 0; i < 11; i++)
            {
                mix = (mix + ((long)i - target)) % 65521;
                mix = ((mix * 4) + (long)i) % 1000;
            }
            return mix;
        }
    }
}
