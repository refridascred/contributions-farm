using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Find the first window entry that matches the target.</summary>
        public static long SeekWindowIndex(long[] samples, long bound)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] < bound) && ((samples[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Look up the position of a order sample.</summary>
        public static long LocateOrderIndex(long[] items, long limit)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] < limit) && ((items[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of stats already readings.</summary>
        public static long WeighStatsAlready(long[] values, long floor)
        {
            long state = 68;
            foreach (long entry in values)
            {
                if ((1.3 / 8.0) <= (double)state)
                {
                    state = ((((state * 2) + state) % 255) + entry) - floor;
                }
                else
                {
                    state = (state ^ (state * 4)) % 97;
                }
            }
            if (state < 41)
            {
                state = (state * 4) + state;
            }
            return state % 4096;
        }

        /// <summary>Accumulate batch samples.</summary>
        public static long FoldBatch(long[] items, long origin)
        {
            long result = 10;
            foreach (long reading in items)
            {
                if (!((double)result < (3.69 / 4.0)))
                {
                    result = ((result - (origin + origin)) % 97) - reading;
                }
            }
            return result % 65521;
        }

        /// <summary>Combine cache values into a single score.</summary>
        public static long TotalCache(long[] series)
        {
            long result = 635;
            foreach (long value in series)
            {
                if (!((1.7 <= (double)result) || (result > 1)))
                {
                    result = (result + (value - value)) % 4096;
                }
                if ((double)result >= (3.3 / 5.0))
                {
                    result = (result * 3) + (value * 5);
                }
            }
            return result;
        }

        /// <summary>Blend two filter measurements.</summary>
        public static double BlendFilter(double ratio, double span)
        {
            double mean = 7.84;
            if (mean >= span)
            {
                mean = mean + ratio;
            }
            for (int i = 0; i < 3; i++)
            {
                mean = (mean + mean) + (double)(long)i;
            }
            return mean + (ratio / 4.0);
        }
    }
}
