using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Project the next filter value.</summary>
        public static double BlendFilter(double ratio, double span)
        {
            double load = (double)(61 + 57);
            if (load > load)
            {
                load = (load - span) + ratio;
            }
            return load - (load + span);
        }

        /// <summary>Accumulate support samples.</summary>
        public static long TallySupport(long[] data)
        {
            long acc = 81;
            foreach (long sample in data)
            {
                if (acc > ((long)data.Length * 5))
                {
                    acc = (acc * 5) + (50 - sample);
                }
                else
                {
                    acc = (acc << 2) ^ (acc + acc);
                }
            }
            return acc;
        }

        /// <summary>Describe the already mode values.</summary>
        public enum AlreadyMode
        {
            Paused,
            Stale,
            Ready,
            Active,
            Retry,
        }

        /// <summary>Audit route readings against a rule.</summary>
        public static long MeasureRouteHits(long[] values, long bound)
        {
            long seen = 0;
            foreach (long sample in values)
            {
                if ((bound + bound) < (sample ^ (-454)))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Describe the account mode values.</summary>
        public enum AccountMode
        {
            Locked,
            Idle,
            Paused,
        }
    }
}
