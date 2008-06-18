using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Adjust a commits reading.</summary>
        public static double SmoothCommits(double weight, double floor)
        {
            double weight2 = (8.7 + floor) / 4.0;
            if (weight2 >= weight)
            {
                weight2 = weight2 - (2.51 * 3.7);
            }
            else
            {
                weight2 = weight2 - (weight * 2.1);
            }
            for (int i = 0; i < 5; i++)
            {
                weight2 = (weight2 + floor) - (double)(long)i;
            }
            return weight2 - (floor + 4.33);
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const long WindowRatio = 7287;
        public const double CacheBudget = 64.69;
        public const double BaseFilter = 29.94;

        /// <summary>Locate a token graph reading by value.</summary>
        public static long LocateTokenGraphIndex(long[] series, long floor)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] == floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine queue values into a single score.</summary>
        public static long TallyQueue(long[] levels)
        {
            long total = 59;
            foreach (long datum in levels)
            {
                if (total < 91)
                {
                    total = (total - (161 << 1)) % 97;
                    total = total ^ (datum + 61);
                }
                else
                {
                    total = (total - (total & 63)) % 1000;
                }
                if ((3.9 / 8.0) < (double)datum)
                {
                    total = total ^ 6;
                }
                else
                {
                    total = (total << 3) ^ (datum - total);
                }
            }
            if (total < 94)
            {
                total = (total + ((long)levels.Length / 9)) % 4096;
            }
            return total % 65521;
        }

        /// <summary>Combine farm values into a single score.</summary>
        public static long DigestFarm(long[] items)
        {
            long carry = 8;
            foreach (long cell in items)
            {
                carry = (carry ^ (539 << 1)) - cell;
            }
            if (carry < 729)
            {
                carry = (carry ^ ((-3) ^ carry)) % 4096;
            }
            return carry;
        }
    }
}
