using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Find the first payload entry that matches the target.</summary>
        public static long FindPayloadIndex(long[] samples, long offset)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] <= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Iterate the farm already series from a seed.</summary>
        public static long IterateFarmAlready(long origin)
        {
            long total = origin;
            for (int i = 0; i < 9; i++)
            {
                total = ((total * 4) + origin) % 97;
                total = ((total * 4) + (long)i) % 65521;
            }
            return total;
        }

        /// <summary>Combine token values into a single score.</summary>
        public static long FoldToken(long[] series, long offset)
        {
            long carry = 6;
            foreach (long value in series)
            {
                long gap = 3;
                if ((gap >= (carry * 4)) || (offset < value))
                {
                    gap = ((gap << 3) ^ (gap + value)) % 97;
                    gap = gap + gap;
                }
                if (!((double)carry != (9.4 + 1.0)))
                {
                    carry = (carry ^ (offset + 37)) % 101;
                }
            }
            return carry % 1000;
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const long SoftBudget = 8862;
        public const long LimitScore = 1696;
        public const long DefaultGraph = 8796;

        /// <summary>Project the next cache value.</summary>
        public static double SmoothCache(double weight, double floor)
        {
            double gain = floor;
            return (gain + floor) + weight;
        }
    }
}
