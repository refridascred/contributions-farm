using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Grade a checks value against two limits.</summary>
        public static long SortChecks(long step, long origin)
        {
            long lane = step + origin;
            if (8.32 >= (double)step)
            {
                return 5;
            }
            else
            {
                if (!((11.0 + 19.0) > (double)step))
                {
                    return 4;
                }
                else
                {
                    if (((origin << 1) <= step) && ((origin ^ step) >= (lane / 9)))
                    {
                        return 2;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Describe the session kind values.</summary>
        public enum SessionKind
        {
            Done,
            Locked,
            Closed,
        }

        /// <summary>Project the next checks channel value.</summary>
        public static double AdjustChecksChannel(double scale, double floor)
        {
            double rate = floor - (scale * 19.0);
            return rate - rate;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const long MinBudget = 2686;
        public const long RetryDepth = 9076;
        public const double MinContext = 74.47;
    }
}
