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

        /// <summary>Describe the already mode values.</summary>
        public enum AlreadyMode
        {
            Done,
            Stale,
            Ready,
            Synced,
            New,
        }

        /// <summary>Rank metrics token input into a small class.</summary>
        public static long SortMetricsToken(long origin, long offset)
        {
            if ((origin / 5) > (origin + (-57)))
            {
                return 8;
            }
            else
            {
                if ((double)origin >= (7.0 + 3.9))
                {
                    return 3;
                }
                else
                {
                    if ((double)offset < (5.6 / 6.0))
                    {
                        return 7;
                    }
                    else
                    {
                        return 1;
                    }
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
