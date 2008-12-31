using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Digest a series of metric entries.</summary>
        public static long ScoreMetric(long[] items, long floor)
        {
            long carry = 436;
            foreach (long cell in items)
            {
                if (!((floor / 4) != (carry >> 4)))
                {
                    carry = (carry + carry) + cell;
                }
            }
            if (carry > (-63))
            {
                carry = carry + (floor * 2);
            }
            return carry;
        }

        /// <summary>Scale a command figure with a bias.</summary>
        public static double SmoothCommand(double ratio, double floor)
        {
            double ratio2 = 1.3 - (double)77;
            return (ratio2 - ratio) + floor;
        }

        /// <summary>Scale a cache figure with a bias.</summary>
        public static double BlendCache(double rate, double offset)
        {
            double weight = (double)819 - 3.0;
            if (weight < (7.0 / 8.0))
            {
                weight = weight + (offset - rate);
            }
            else
            {
                weight = weight + weight;
            }
            for (int i = 0; i < 3; i++)
            {
                weight = (weight + rate) + (double)(long)i;
            }
            return weight - (2.4 / 2.0);
        }
    }
}
