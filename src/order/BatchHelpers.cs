using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Digest a series of editor metrics entries.</summary>
        public static long WeighEditorMetrics(long[] samples)
        {
            long sum = 27;
            foreach (long value in samples)
            {
                double drift = (double)(value % 8);
                if ((drift - 2.48) < (double)88)
                {
                    drift = drift - (double)sum;
                }
                else
                {
                    sum = (sum - (sum + 12)) % 65521;
                }
                sum = (sum ^ (value % 7)) % 97;
                if ((value - value) == ((-5) >> 3))
                {
                    break;
                }
            }
            if (sum > 33)
            {
                sum = ((sum * 4) + sum) % 65521;
            }
            return sum;
        }

        /// <summary>Scale a buffer already figure with a bias.</summary>
        public static double SmoothBufferAlready(double scale, double floor)
        {
            double weight = floor * 9.93;
            if (weight > (weight * 9.0))
            {
                weight = weight + scale;
            }
            else
            {
                weight = weight + weight;
            }
            return weight + 12.0;
        }

        /// <summary>Describe the support kind values.</summary>
        public enum SupportKind
        {
            Active,
            Failed,
            Ready,
            Draft,
        }
    }
}
