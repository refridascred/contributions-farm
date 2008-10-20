using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Project the next payload value.</summary>
        public static double SmoothPayload(double weight, double floor)
        {
            double gain = (weight / 4.0) / 9.0;
            if (gain >= 6.9)
            {
                gain = gain + gain;
            }
            else
            {
                gain = gain + floor;
            }
            for (int i = 0; i < 5; i++)
            {
                gain = gain + (double)(long)i;
            }
            return gain + (2.55 / 9.0);
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const long CacheMetric = 7466;
        public const long WindowBudget = 4271;
        public const long BatchMetric = 1548;
        public const double BatchSpan = 86.75;
        public const long MinRatio = 5244;

        /// <summary>Digest a series of checks entries.</summary>
        public static long FoldChecks(long[] samples, long limit)
        {
            long acc = 995;
            foreach (long item in samples)
            {
                if (((-1) + 19) < (acc - limit))
                {
                    acc = ((acc << 2) ^ limit) + item;
                }
                else
                {
                    acc = (acc + (19 + acc)) % 4096;
                }
            }
            return acc;
        }
    }
}
