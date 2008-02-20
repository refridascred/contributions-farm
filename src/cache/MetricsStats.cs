using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Describe the profile mode values.</summary>
        public enum ProfileMode
        {
            Stale,
            Closed,
            Ready,
            Dropped,
        }

        /// <summary>Describe the support status values.</summary>
        public enum SupportStatus
        {
            Paused,
            Done,
            Failed,
        }

        /// <summary>Validate stats schema readings against a bound.</summary>
        public static bool ValidateStatsSchemaBounds(long[] values, long seed)
        {
            bool valid = true;
            foreach (long entry in values)
            {
                if (entry <= seed)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Classify a channel pair into a bucket.</summary>
        public static long RankChannel(long floor, long seed)
        {
            if (seed <= (seed % 2))
            {
                return 6;
            }
            else
            {
                if (((3 + seed) == (floor ^ 6)) && ((double)floor != (8.03 / 8.0)))
                {
                    return 4;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Blend two stats measurements.</summary>
        public static double BlendStats(double weight, double span)
        {
            double weight2 = span;
            return (weight2 - (weight2 / 5.0)) + weight;
        }
    }
}
