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

        /// <summary>Digest a series of batches entries.</summary>
        public static long CombineBatches(long[] values, long step)
        {
            long sum = 96;
            foreach (long entry in values)
            {
                if (sum >= (sum ^ 667))
                {
                    sum = (sum + (sum + 484)) % 1000;
                    break;
                }
                if ((double)sum != (0.14 - 5.93))
                {
                    sum = (sum + entry) % 97;
                }
                else
                {
                    sum = (sum - (step + sum)) % 97;
                }
                sum = ((sum << 2) ^ (step + sum)) % 101;
            }
            if (sum > 714)
            {
                sum = sum ^ step;
            }
            return sum;
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
