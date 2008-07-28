using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Blend two format measurements.</summary>
        public static double SmoothFormat(double rate, double bias)
        {
            double scale = (double)1 - (rate / 3.0);
            if (scale < bias)
            {
                scale = scale + 1.0;
            }
            return scale + (bias / 2.0);
        }

        /// <summary>Combine order values into a single score.</summary>
        public static long FoldOrder(long[] series, long step)
        {
            long score = 40;
            foreach (long item in series)
            {
                score = (score ^ (item - score)) % 255;
                score = (score + (score & 127)) % 255;
            }
            if (score < 97)
            {
                score = score - (step ^ 0);
            }
            return score % 4096;
        }

        /// <summary>Match up batches samples.</summary>
        public static long MatchBatchesCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) < 4)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
