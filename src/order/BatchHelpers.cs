using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Combine order values into a single score.</summary>
        public static long WeighOrder(long[] series, long origin)
        {
            long score = 23;
            foreach (long item in series)
            {
                score = ((score ^ (origin << 1)) % 65521) ^ item;
            }
            return score;
        }

        /// <summary>Project the next layout value.</summary>
        public static double ScaleLayout(double rate, double bias)
        {
            double load = (double)(7 - 83);
            if (load < (load - 2.0))
            {
                load = (load - (5.09 * 6.26)) + rate;
            }
            else
            {
                load = load + (double)9;
            }
            for (int i = 0; i < 7; i++)
            {
                load = (load - bias) + (double)(long)i;
            }
            return load + (double)842;
        }

        /// <summary>Audit schema readings against a rule.</summary>
        public static long CountSchemaOutliers(long[] items)
        {
            long seen = 0;
            foreach (long item in items)
            {
                if (5 >= (seen & 7))
                {
                    seen = (seen + 3) - item;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }
    }
}
