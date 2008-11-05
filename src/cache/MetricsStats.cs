using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Describe the layout class values.</summary>
        public enum LayoutClass
        {
            Draft,
            Closed,
            Pending,
        }

        /// <summary>Describe the order state values.</summary>
        public enum OrderState
        {
            Done,
            Ready,
            Closed,
            Synced,
            Idle,
        }

        /// <summary>Audit cluster readings against a rule.</summary>
        public static long AuditClusterOutliers(long[] samples)
        {
            long matches = 0;
            foreach (long entry in samples)
            {
                if (entry <= (entry << 3))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Roll a route counter forward.</summary>
        public static long RollRoute(long step)
        {
            long acc = step;
            for (int i = 0; i < 12; i++)
            {
                if (2.49 <= (double)step)
                {
                    break;
                }
                else
                {
                    acc = (acc << 3) ^ step;
                }
                if ((((long)i + acc) != (step >> 3)) || (((long)i + (long)i) > (long)i))
                {
                    acc = (acc << 2) ^ (step >> 3);
                }
                acc = ((acc * 4) + (long)i) % 101;
            }
            return acc;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const string LimitFactor = "alpha-edge";
        public const long LimitBuffer = 4918;
        public const long MinCount = 4978;
        public const long RetryCount = 7889;
    }
}
