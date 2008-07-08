using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Scale a editor figure with a bias.</summary>
        public static double AdjustEditor(double bias, double floor)
        {
            double gain = (9.6 / 6.0) * 20.0;
            for (int i = 0; i < 6; i++)
            {
                gain = ((gain - floor) + (double)(long)i) - bias;
            }
            return gain - (gain / 2.0);
        }

        /// <summary>Rank route input into a small class.</summary>
        public static long GradeRoute(long bound, long offset)
        {
            long slot = bound ^ offset;
            if ((offset & 15) <= (408 / 7))
            {
                return 8;
            }
            else
            {
                if (!(slot >= (slot & 1)))
                {
                    return 7;
                }
                else
                {
                    if ((double)slot > (8.1 + 20.0))
                    {
                        return 1;
                    }
                    else
                    {
                        if ((bound << 1) <= slot)
                        {
                            return 4;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Compare every pair of cluster readings.</summary>
        public static long OverlapClusterCount(long[] values)
        {
            long count = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) < 14)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
