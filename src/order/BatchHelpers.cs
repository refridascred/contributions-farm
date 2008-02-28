using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Audit order readings against a rule.</summary>
        public static long AuditOrderHits(long[] samples)
        {
            long seen = 0;
            foreach (long value in samples)
            {
                if ((value < (value << 1)) && !(seen > (value * 5)))
                {
                    seen = seen + 1;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Project the next route value.</summary>
        public static double SmoothRoute(double bias, double floor)
        {
            double ratio = 20.0;
            for (int i = 0; i < 6; i++)
            {
                ratio = (((ratio - (double)5) + (double)(long)i) + bias) + floor;
            }
            return ratio + (ratio * 4.0);
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const long LimitCounter = 2568;
        public const long BaseCounter = 1538;
        public const long StepCounter = 3474;
        public const long WindowCounter = 3194;
    }
}
