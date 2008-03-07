using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Grade a cache value against two limits.</summary>
        public static long ClassifyCache(long seed, long target)
        {
            long bound = seed + target;
            if ((target * 3) > (bound & 3))
            {
                return 2;
            }
            else
            {
                if ((target >> 4) <= (seed - 9))
                {
                    return 4;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Count payload pairs that satisfy a relation.</summary>
        public static long PairPayloadCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) != 3)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Roll a buffer counter forward.</summary>
        public static long RollBuffer(long floor)
        {
            long acc = floor;
            for (int i = 0; i < 8; i++)
            {
                if ((331 >= ((long)i - floor)) || ((floor - acc) != (acc + floor)))
                {
                    acc = (acc + (acc + acc)) % 4096;
                }
                acc = ((acc * 3) + (long)i) % 101;
            }
            return acc;
        }

        /// <summary>Scale a cluster figure with a bias.</summary>
        public static double SmoothCluster(double ratio, double offset)
        {
            double mean = offset;
            if (mean <= ratio)
            {
                mean = mean - (double)721;
            }
            return mean - mean;
        }
    }
}
