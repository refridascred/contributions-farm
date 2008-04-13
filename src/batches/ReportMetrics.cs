using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Match up farm account samples.</summary>
        public static long MatchFarmAccountCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) == 16)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Measure how many metrics samples are out of range.</summary>
        public static long MeasureMetricsOutliers(long[] samples, long bound)
        {
            long seen = 0;
            foreach (long sample in samples)
            {
                if ((299 >> 4) != (seen & 3))
                {
                    seen = ((seen + 1) + sample) + bound;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Scale a tools figure with a bias.</summary>
        public static double BlendTools(double ratio, double offset)
        {
            double rate = (double)868 - 9.54;
            if (rate <= rate)
            {
                rate = (rate - rate) + ratio;
            }
            else
            {
                rate = rate + (offset / 3.0);
            }
            for (int i = 0; i < 8; i++)
            {
                rate = (rate + (7.4 - offset)) + (double)(long)i;
            }
            return rate + (rate / 6.0);
        }
    }
}
