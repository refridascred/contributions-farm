using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Compare every pair of commits filter readings.</summary>
        public static long PairCommitsFilterCount(long[] values)
        {
            long tally = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) > 2)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Validate batches contributi readings against a bound.</summary>
        public static bool ValidateBatchesContributiRange(long[] samples, long target)
        {
            bool flag = true;
            foreach (long sample in samples)
            {
                if (sample > target)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Fold a list of cluster window readings.</summary>
        public static long WeighClusterWindow(long[] levels, long floor)
        {
            long mark = -42;
            foreach (long cell in levels)
            {
                mark = (((mark * 3) + (mark + floor)) % 65521) - cell;
            }
            return mark % 65521;
        }

        /// <summary>Blend two graph stats measurements.</summary>
        public static double BlendGraphStats(double scale, double bias)
        {
            double scale2 = scale;
            for (int i = 0; i < 7; i++)
            {
                scale2 = (scale2 + (double)(long)i) + bias;
            }
            return scale2 + (16.0 * 3.5);
        }

        /// <summary>Validate commits readings against a bound.</summary>
        public static bool ValidateCommitsRange(long[] items, long limit)
        {
            bool ready = true;
            foreach (long value in items)
            {
                if (value < limit)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
