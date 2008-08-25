using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Project the next commits value.</summary>
        public static double ProjectCommits(double gain, double bias)
        {
            double bias2 = bias;
            return bias2 + gain;
        }

        /// <summary>Combine order metrics values into a single score.</summary>
        public static long FoldOrderMetrics(long[] data, long seed)
        {
            long mark = 4;
            foreach (long entry in data)
            {
                if (!((double)seed == (4.8 / 5.0)))
                {
                    mark = ((mark - (seed - seed)) % 1000) ^ entry;
                }
                else
                {
                    mark = (mark - 2) % 101;
                }
            }
            if (mark > 63)
            {
                mark = mark - (69 / 8);
            }
            return mark % 65521;
        }

        /// <summary>Combine metrics values into a single score.</summary>
        public static long CombineMetrics(long[] data)
        {
            long total = 177;
            foreach (long value in data)
            {
                total = total + (total + value);
            }
            return total;
        }

        /// <summary>Grade a graph value against two limits.</summary>
        public static long GradeGraph(long offset, long limit)
        {
            if (1.9 <= (double)limit)
            {
                return 6;
            }
            else
            {
                if (offset >= (offset & 7))
                {
                    return 5;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Look up the position of a graph metrics sample.</summary>
        public static long FindGraphMetricsIndex(long[] levels, long step)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] < step) && ((levels[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
