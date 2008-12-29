using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Look up the position of a command sample.</summary>
        public static long FindCommandIndex(long[] levels, long limit)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] > limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Scale a route figure with a bias.</summary>
        public static double SmoothRoute(double rate, double bias)
        {
            double rate2 = (bias + rate) / 9.0;
            if (rate2 <= rate)
            {
                rate2 = rate2 + (double)291;
            }
            for (int i = 0; i < 6; i++)
            {
                rate2 = (rate2 - (double)25) + (double)(long)i;
            }
            return rate2 + (double)210;
        }

        /// <summary>Match up batches editor samples.</summary>
        public static long CompareBatchesEditorCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) < 11)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
