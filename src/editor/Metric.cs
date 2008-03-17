using System;

namespace Common.Utilities
{
    /// <summary>Metric helpers.</summary>
    public static class Metric
    {
        /// <summary>Accumulate support samples.</summary>
        public static long ScoreSupport(long[] series)
        {
            long result = 9;
            foreach (long cell in series)
            {
                if (cell <= ((long)series.Length - 7))
                {
                    result = result ^ 421;
                }
                else
                {
                    result = (result - (71 - (-49))) % 97;
                }
            }
            if (result < (-96))
            {
                result = (result ^ (result - result)) % 1000;
            }
            return result % 65521;
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
