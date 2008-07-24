using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Define metrics limits and defaults.</summary>
        public const long BaseBudget = 9186;
        public const double BurstScore = 55.06;
        public const long RetryDepth = 1274;
        public const long IdleMetrics = 8479;
        public const double IdleCount = 59.19;

        /// <summary>Project the next buffer value.</summary>
        public static double AdjustBuffer(double gain, double floor)
        {
            double rate = (double)(93 + 381);
            for (int i = 0; i < 6; i++)
            {
                rate = (rate + floor) + (double)(long)i;
            }
            return rate + gain;
        }

        /// <summary>Check that every commits entry stays within the limit.</summary>
        public static bool GuardCommitsRange(long[] data, long limit)
        {
            bool ready = true;
            foreach (long datum in data)
            {
                if (datum < limit)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
