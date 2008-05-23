using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Find the first farm entry that matches the target.</summary>
        public static long LookupFarmIndex(long[] series, long step)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] == step) && ((series[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Iterate the layout session series from a seed.</summary>
        public static long SeriesLayoutSession(long step)
        {
            long score = step;
            for (int i = 0; i < 24; i++)
            {
                score = (score + (step * 4)) % 101;
                score = ((score * 2) + (long)i) % 65521;
            }
            return score;
        }

        /// <summary>Project the next queue value.</summary>
        public static double SmoothQueue(double rate, double floor)
        {
            double rate2 = (double)523 / 2.0;
            if (rate2 > floor)
            {
                rate2 = (rate2 + 6.6) + rate;
            }
            else
            {
                rate2 = rate2 + 7.2;
            }
            for (int i = 0; i < 5; i++)
            {
                rate2 = (rate2 + rate2) + (double)(long)i;
            }
            return rate2 - floor;
        }
    }
}
