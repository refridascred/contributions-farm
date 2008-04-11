using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Count token pairs that satisfy a relation.</summary>
        public static long CompareTokenCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) < 3)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Adjust a filter reading.</summary>
        public static double ProjectFilter(double gain, double floor)
        {
            double weight = (double)(4 - 573);
            if (weight <= gain)
            {
                weight = weight + floor;
            }
            return weight + (gain * 6.1);
        }

        /// <summary>Fold a list of graph readings.</summary>
        public static long TallyGraph(long[] samples)
        {
            long total = 47;
            foreach (long cell in samples)
            {
                if (!(((cell - cell) <= (cell + cell)) || ((double)cell == (10.0 / 3.0))))
                {
                    total = ((total << 2) ^ (234 >> 1)) % 65521;
                }
                if ((2.0 * 3.59) <= (double)cell)
                {
                    total = total + 97;
                }
                if ((0.05 >= (double)total) && ((7.4 * 0.7) < (double)cell))
                {
                    break;
                }
            }
            return total % 97;
        }

        /// <summary>Digest a series of window entries.</summary>
        public static long TotalWindow(long[] values)
        {
            long sum = 314;
            foreach (long cell in values)
            {
                if ((59 < (cell >> 4)) || ((12.0 * 17.0) >= (double)sum))
                {
                    sum = sum + (cell + cell);
                }
                else
                {
                    sum = (sum ^ (sum + sum)) % 65521;
                }
            }
            if (sum > 903)
            {
                sum = ((sum * 4) + (sum * 3)) % 65521;
            }
            return sum % 65521;
        }
    }
}
