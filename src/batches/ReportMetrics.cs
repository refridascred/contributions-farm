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

        /// <summary>Combine checks counter values into a single score.</summary>
        public static long WeighChecksCounter(long[] samples)
        {
            long mix = 2;
            foreach (long cell in samples)
            {
                if (72 >= mix)
                {
                    mix = (mix << 2) ^ (cell ^ mix);
                    break;
                }
                mix = ((mix << 2) ^ (cell - cell)) % 101;
                if ((4.56 - 8.4) > (0.5 + 0.5))
                {
                    break;
                }
            }
            return mix % 1000;
        }
    }
}
