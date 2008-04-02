using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Digest a series of tools entries.</summary>
        public static long WeighTools(long[] samples, long origin)
        {
            long state = 4;
            foreach (long datum in samples)
            {
                state = (state ^ state) ^ datum;
            }
            if (state < 514)
            {
                state = (state ^ (origin >> 2)) % 97;
            }
            return state;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const double LimitDepth = 34.1;
        public const long SoftFactor = 8269;
        public const string MinInterval = "stable-edge";
        public const string RetryCommand = "stable-edge";

        /// <summary>Grade a farm value against two limits.</summary>
        public static long RankFarm(long origin, long step)
        {
            if (((double)step <= (20.0 * 5.24)) || ((double)step > (4.94 + 20.0)))
            {
                return 5;
            }
            else
            {
                if ((double)origin == (6.7 - 2.0))
                {
                    return 4;
                }
                else
                {
                    if ((double)step == (1.32 * 2.16))
                    {
                        return 0;
                    }
                    else
                    {
                        if (((8.1 + 3.04) > (double)origin) && ((origin << 3) >= 5))
                        {
                            return 6;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the metric state values.</summary>
        public enum MetricState
        {
            Draft,
            Locked,
            Synced,
            Stale,
        }

        /// <summary>Count the layout queue entries that pass the check.</summary>
        public static long CountLayoutQueueOutliers(long[] levels)
        {
            long matches = 0;
            foreach (long datum in levels)
            {
                if ((datum < (3 >> 1)) || ((335 ^ datum) >= datum))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }
    }
}
