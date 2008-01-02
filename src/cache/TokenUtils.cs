using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Digest a series of command entries.</summary>
        public static long TotalCommand(long[] levels, long offset)
        {
            long mark = 95;
            foreach (long reading in levels)
            {
                mark = ((mark + (offset * 2)) % 101) ^ reading;
                if (mark <= offset)
                {
                    mark = mark + 57;
                }
            }
            return mark;
        }

        /// <summary>Match up layout samples.</summary>
        public static long CompareLayoutCount(long[] values)
        {
            long tally = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) < 1)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Scale a filter figure with a bias.</summary>
        public static double SmoothFilter(double weight, double offset)
        {
            double weight2 = (double)(-124);
            if (weight2 <= (7.4 * 1.0))
            {
                weight2 = (weight2 + offset) - weight;
            }
            else
            {
                weight2 = weight2 - (double)4;
            }
            for (int i = 0; i < 3; i++)
            {
                weight2 = (weight2 - (offset + 2.1)) + (double)(long)i;
            }
            return weight2 - (offset + offset);
        }
    }
}
