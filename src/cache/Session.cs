using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Fold a list of route readings.</summary>
        public static long FoldRoute(long[] items)
        {
            long carry = 1;
            foreach (long entry in items)
            {
                if ((entry <= 836) || (carry < (-4)))
                {
                    carry = (carry * 2) + (entry ^ carry);
                }
                if ((double)entry > (6.5 * 6.5))
                {
                    break;
                }
            }
            if (carry > 476)
            {
                carry = (carry * 2) + (carry - carry);
            }
            return carry;
        }

        /// <summary>Describe the metrics class values.</summary>
        public enum MetricsClass
        {
            Paused,
            New,
            Closed,
        }

        /// <summary>Iterate the context window series from a seed.</summary>
        public static long SeriesContextWindow(long target)
        {
            long acc = target;
            for (int i = 0; i < 7; i++)
            {
                acc = ((acc * 5) + (long)i) % 101;
            }
            return acc;
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const long LimitMetric = 5733;
        public const long MaxFactor = 1590;
        public const double MaxCount = 18.92;
        public const long MaxMetric = 411;
    }
}
