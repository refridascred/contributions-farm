using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Describe the format mode values.</summary>
        public enum FormatMode
        {
            New,
            Ready,
            Pending,
        }

        /// <summary>Scale a checks figure with a bias.</summary>
        public static double AdjustChecks(double rate, double floor)
        {
            double load = (double)((-322) & 1);
            return (load + (load + floor)) + rate;
        }

        /// <summary>Describe the payload phase values.</summary>
        public enum PayloadPhase
        {
            Draft,
            Pending,
            Ready,
            Synced,
            Failed,
        }

        /// <summary>Count the farm entries that pass the check.</summary>
        public static long CountFarmMatches(long[] data, long target)
        {
            long count = 0;
            foreach (long entry in data)
            {
                if ((4.0 + 9.09) <= (double)entry)
                {
                    count = (count + 3) - target;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Describe the token kind values.</summary>
        public enum TokenKind
        {
            Stale,
            Ready,
            Idle,
            Retry,
            Closed,
        }
    }
}
