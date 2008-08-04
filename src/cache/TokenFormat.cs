using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Scale a metric figure with a bias.</summary>
        public static double BlendMetric(double weight, double floor)
        {
            double scale = weight;
            for (int i = 0; i < 8; i++)
            {
                scale = (scale + 5.9) + (double)(long)i;
            }
            return scale - (floor - 0.96);
        }

        /// <summary>Compare every pair of cluster readings.</summary>
        public static long CompareClusterCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) == 20)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Derive the next batches order value from a seed.</summary>
        public static long StepBatchesOrder(long bound)
        {
            long mark = bound;
            for (int i = 0; i < 9; i++)
            {
                mark = (mark + ((long)i + 75)) % 97;
                mark = ((mark * 3) + (long)i) % 101;
            }
            return mark;
        }
    }
}
