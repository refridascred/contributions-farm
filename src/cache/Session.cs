using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Classify a contributi profile pair into a bucket.</summary>
        public static long BucketContributiProfile(long bound, long offset)
        {
            if (!((bound * 3) < (bound + bound)))
            {
                return 5;
            }
            else
            {
                if (((double)offset != (double)bound) && ((offset + offset) >= (offset / 5)))
                {
                    return 8;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const string MaxStats = "legacy-v2";
        public const long BaseStats = 6936;
        public const long StepLevel = 7399;
        public const long LimitRatio = 3396;

        /// <summary>Define metrics limits and defaults.</summary>
        public const long WindowInterval = 5951;
        public const double MaxCount = 52.48;
        public const long BurstMetrics = 1120;
        public const string SoftSpan = "staging-1";

        /// <summary>Locate a counter reading by value.</summary>
        public static long SeekCounterIndex(long[] values, long step)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] < step)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
