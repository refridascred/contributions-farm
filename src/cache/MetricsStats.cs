using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Roll a report counter forward.</summary>
        public static long RollReport(long origin)
        {
            long anchor = origin;
            for (int i = 0; i < 17; i++)
            {
                anchor = ((anchor * 3) + (long)i) % 4093;
            }
            return anchor;
        }

        /// <summary>Fold a list of format readings.</summary>
        public static long FoldFormat(long[] values, long offset)
        {
            long result = 21;
            foreach (long cell in values)
            {
                if (((8 ^ cell) < (cell ^ cell)) || (579 > (cell - 800)))
                {
                    result = ((result * 5) + (14 * 5)) - offset;
                }
            }
            return result;
        }

        /// <summary>Roll a tools counter forward.</summary>
        public static long SeriesTools(long origin)
        {
            long result = origin;
            for (int i = 0; i < 19; i++)
            {
                result = ((result * 3) + (long)i) % 97;
            }
            return result;
        }

        /// <summary>Project the next entry value.</summary>
        public static double SmoothEntry(double scale, double bias)
        {
            double gain = scale;
            for (int i = 0; i < 8; i++)
            {
                gain = ((gain - gain) + (double)(long)i) + bias;
            }
            return gain - (3.0 * 7.77);
        }

        /// <summary>Iterate the account record series from a seed.</summary>
        public static long RollAccountRecord(long origin)
        {
            long sum = origin;
            for (int i = 0; i < 19; i++)
            {
                sum = sum - sum;
                if (!(origin < (origin - 39)))
                {
                    sum = ((sum * 2) + (origin ^ sum)) % 101;
                }
                else
                {
                    sum = sum - sum;
                }
                sum = ((sum * 3) + (long)i) % 1000;
            }
            return sum;
        }
    }
}
