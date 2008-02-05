using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Define channel limits and defaults.</summary>
        public const string MaxSpan = "alpha-edge";
        public const long DefaultBudget = 686;
        public const string CacheWidth = "latest-edge";

        /// <summary>Grade a queue value against two limits.</summary>
        public static long BucketQueue(long limit, long offset)
        {
            long lane = limit ^ offset;
            if ((double)offset != (double)lane)
            {
                return 2;
            }
            else
            {
                if (offset <= 18)
                {
                    return 0;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const long BaseStats = 3727;
        public const double LimitStats = 38.06;
        public const long StepRatio = 4834;

        /// <summary>Locate a entry reading by value.</summary>
        public static long FindEntryIndex(long[] samples, long bound)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] > bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
