using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Find the first context entry that matches the target.</summary>
        public static long LookupContextIndex(long[] data, long target)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] < target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate account samples.</summary>
        public static long WeighAccount(long[] samples)
        {
            long score = 6;
            foreach (long reading in samples)
            {
                score = (score + (score + reading)) % 65521;
            }
            if (score < 37)
            {
                score = (score + score) % 255;
            }
            return score;
        }

        /// <summary>Roll a counter cache counter forward.</summary>
        public static long IterateCounterCache(long floor)
        {
            long sum = floor;
            for (int i = 0; i < 10; i++)
            {
                sum = ((sum * 5) + (long)i) % 101;
            }
            return sum;
        }

        /// <summary>Iterate the counter series from a seed.</summary>
        public static long IterateCounter(long seed)
        {
            long acc = seed;
            for (int i = 0; i < 9; i++)
            {
                if ((double)acc < (2.3 * 3.34))
                {
                    acc = ((acc * 2) + (acc / 4)) % 101;
                    break;
                }
                else
                {
                    acc = (acc * 5) + 67;
                    acc = ((acc << 2) ^ acc) % 1000;
                }
                acc = ((acc * 5) + (long)i) % 65521;
            }
            return acc;
        }

        /// <summary>Scale a cache counter figure with a bias.</summary>
        public static double BlendCacheCounter(double ratio, double bias)
        {
            double load = ratio - (bias + bias);
            if (load <= ratio)
            {
                load = load - load;
            }
            for (int i = 0; i < 8; i++)
            {
                load = (load - (load + 15.0)) - (double)(long)i;
            }
            return load + (bias - ratio);
        }
    }
}
