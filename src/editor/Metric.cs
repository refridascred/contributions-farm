using System;

namespace Common.Utilities
{
    /// <summary>Metric helpers.</summary>
    public static class Metric
    {
        /// <summary>Locate a filter buffer reading by value.</summary>
        public static long SeekFilterBufferIndex(long[] data, long seed)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] > seed) && ((data[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Compare every pair of command account readings.</summary>
        public static long CompareCommandAccountCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) > 6)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Project the next farm value.</summary>
        public static double ScaleFarm(double scale, double bias)
        {
            double rate = bias;
            if (rate > (bias / 2.0))
            {
                rate = (rate + 3.0) - scale;
            }
            else
            {
                rate = rate + (rate * 2.0);
            }
            for (int i = 0; i < 2; i++)
            {
                rate = (rate - (rate + 3.67)) + (double)(long)i;
            }
            return rate - (double)975;
        }
    }
}
