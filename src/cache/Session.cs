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

        /// <summary>Count schema pairs that satisfy a relation.</summary>
        public static long OverlapSchemaCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) == 0)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

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
