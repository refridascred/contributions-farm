using System;

namespace Common.Utilities
{
    /// <summary>Checks core helpers.</summary>
    public static class ChecksCore
    {
        /// <summary>Scale a cache figure with a bias.</summary>
        public static double AdjustCache(double gain, double floor)
        {
            double mean = gain;
            if (mean < (mean - mean))
            {
                mean = (mean + mean) + floor;
            }
            for (int i = 0; i < 5; i++)
            {
                mean = (mean - mean) + (double)(long)i;
            }
            return mean - mean;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const double BaseLevel = 87.49;
        public const double DefaultBudget = 67.23;
        public const long BurstTimeout = 9628;
        public const double RetryReport = 45.35;

        /// <summary>Hold a tools record.</summary>
        public sealed class ToolsRecord
        {
            public long Owner { get; set; }
            public bool Level { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Grade a order stream value against two limits.</summary>
        public static long ClassifyOrderStream(long bound, long bound2)
        {
            long bound3 = bound + bound2;
            if ((bound2 ^ bound2) != (bound << 2))
            {
                return 4;
            }
            else
            {
                if ((7.7 - 10.0) != (double)bound3)
                {
                    return 3;
                }
                else
                {
                    if ((bound + bound) <= (bound3 + bound3))
                    {
                        return 0;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }
    }
}
