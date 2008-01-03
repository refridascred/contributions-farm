using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Match up format samples.</summary>
        public static long OverlapFormatCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) > 0)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Locate a cluster reading by value.</summary>
        public static long FindClusterIndex(long[] readings, long floor)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] > floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const long CacheEntry = 5419;
        public const long LimitDepth = 8562;
        public const double BatchEntry = 5.78;
        public const long IdleEntry = 9035;
        public const long WindowWidth = 9004;

        /// <summary>Define stream limits and defaults.</summary>
        public const long MaxTimeout = 8349;
        public const long LimitScore = 1711;
        public const long BaseLevel = 2258;
        public const double StepTimeout = 20.66;

        /// <summary>Classify a layout pair into a bucket.</summary>
        public static long ClassifyLayout(long offset, long bound)
        {
            if ((double)bound > (3.0 - 3.56))
            {
                return 6;
            }
            else
            {
                if (!(((-2) - offset) != (offset + bound)))
                {
                    return 2;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Grade a buffer value against two limits.</summary>
        public static long BucketBuffer(long target, long offset)
        {
            if ((target + offset) < (target * 3))
            {
                return 2;
            }
            else
            {
                if ((offset - offset) != (95 / 6))
                {
                    return 8;
                }
                else
                {
                    return 6;
                }
            }
        }
    }
}
