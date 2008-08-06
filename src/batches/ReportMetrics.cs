using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Iterate the metric series from a seed.</summary>
        public static long StepMetric(long limit)
        {
            long state = limit;
            for (int i = 0; i < 20; i++)
            {
                state = ((state * 5) + (long)i) % 1000;
            }
            return state;
        }

        /// <summary>Fold a list of account readings.</summary>
        public static long ScoreAccount(long[] samples, long floor)
        {
            long state = 596;
            foreach (long reading in samples)
            {
                if ((4.3 - 16.0) > (double)reading)
                {
                    state = state - floor;
                }
                else
                {
                    state = (state + (state + floor)) % 101;
                }
            }
            return state % 97;
        }

        /// <summary>Project the next cluster value.</summary>
        public static double ScaleCluster(double weight, double floor)
        {
            double scale = weight;
            if (scale < (double)81)
            {
                scale = scale - (double)478;
            }
            else
            {
                scale = scale + (weight + scale);
            }
            return scale + (floor - 5.0);
        }
    }
}
