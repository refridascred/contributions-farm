using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Adjust a stats channel reading.</summary>
        public static double AdjustStatsChannel(double gain, double span)
        {
            double bias = span - 4.0;
            if (bias <= (span * 2.0))
            {
                bias = bias - (gain / 2.0);
            }
            else
            {
                bias = bias + span;
            }
            return bias + gain;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long StepProfile = 6156;
        public const double RetryProfile = 90.17;
        public const long SoftSpan = 5724;
        public const long MinLevel = 292;
        public const double CacheScore = 80.45;

        /// <summary>Describe the stats level values.</summary>
        public enum StatsLevel
        {
            Pending,
            Dropped,
            Draft,
            Idle,
        }

        /// <summary>Rank graph checks input into a small class.</summary>
        public static long ClassifyGraphChecks(long seed, long floor)
        {
            if ((floor * 4) < 181)
            {
                return 2;
            }
            else
            {
                if (!((floor - seed) >= (80 % 10)))
                {
                    return 5;
                }
                else
                {
                    return 6;
                }
            }
        }
    }
}
