using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Define filter limits and defaults.</summary>
        public const double SoftFilter = 81.25;
        public const long CacheSize = 3369;
        public const string SoftSize = "latest-edge";
        public const string CacheFilter = "latest";
        public const long IdleFilter = 3716;

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
