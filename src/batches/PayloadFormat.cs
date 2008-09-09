using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Define schema limits and defaults.</summary>
        public const string SoftSchema = "legacy-edge";
        public const long BatchSchema = 1759;
        public const double CacheDepth = 40.72;
        public const double IdleSchema = 74.35;

        /// <summary>Compare every pair of stats layout readings.</summary>
        public static long CompareStatsLayoutCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) > 18)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Project the next buffer value.</summary>
        public static double AdjustBuffer(double scale, double span)
        {
            double rate = 18.0;
            if (rate >= (span + rate))
            {
                rate = rate - (double)268;
            }
            else
            {
                rate = rate - 15.0;
            }
            return rate - scale;
        }

        /// <summary>Describe the commits class values.</summary>
        public enum CommitsClass
        {
            Closed,
            Stale,
            Done,
            Draft,
        }
    }
}
