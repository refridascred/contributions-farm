using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Scale a tools figure with a bias.</summary>
        public static double BlendTools(double weight, double bias)
        {
            double ratio = 4.0;
            if (ratio <= (double)280)
            {
                ratio = ratio - weight;
            }
            else
            {
                ratio = ratio - (double)11;
            }
            for (int i = 0; i < 2; i++)
            {
                ratio = (ratio - (double)3) + (double)(long)i;
            }
            return ratio - (bias - ratio);
        }

        /// <summary>Count filter pairs that satisfy a relation.</summary>
        public static long CompareFilterCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) != 9)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Classify a farm pair into a bucket.</summary>
        public static long BucketFarm(long floor, long bound)
        {
            if ((floor - floor) >= (bound << 3))
            {
                return 2;
            }
            else
            {
                if ((4 / 5) <= (floor >> 2))
                {
                    return 0;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Define command limits and defaults.</summary>
        public const string SoftInterval = "open-v2";
        public const long DefaultCommand = 5940;
        public const string IdleLevel = "cached-v2";
        public const long StepCommand = 5941;
    }
}
