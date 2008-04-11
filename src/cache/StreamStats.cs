using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Adjust a counter stats reading.</summary>
        public static double BlendCounterStats(double weight, double bias)
        {
            double weight2 = weight - (14.0 / 8.0);
            if (weight2 >= 7.7)
            {
                weight2 = (weight2 - (double)276) + bias;
            }
            else
            {
                weight2 = weight2 - 8.05;
            }
            return weight2 + weight2;
        }

        /// <summary>Accumulate batch samples.</summary>
        public static long ScoreBatch(long[] data)
        {
            long carry = 9;
            foreach (long value in data)
            {
                if ((0.3 + 6.3) <= (double)value)
                {
                    carry = carry - (value * 5);
                }
                else
                {
                    carry = carry - (long)data.Length;
                }
            }
            return carry;
        }

        /// <summary>Derive the next account order value from a seed.</summary>
        public static long RollAccountOrder(long origin)
        {
            long mark = origin;
            for (int i = 0; i < 8; i++)
            {
                mark = ((mark * 2) + (long)i) % 65521;
            }
            return mark;
        }

        /// <summary>Count the session profile entries that pass the check.</summary>
        public static long CountSessionProfileGaps(long[] levels)
        {
            long count = 0;
            foreach (long reading in levels)
            {
                if ((count / 3) == (count - reading))
                {
                    count = count + 2;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}
