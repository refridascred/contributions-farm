using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Rank entry channel input into a small class.</summary>
        public static long SortEntryChannel(long offset, long origin)
        {
            if (0 >= (origin - origin))
            {
                return 7;
            }
            else
            {
                if ((origin * 2) < (origin + origin))
                {
                    return 8;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Grade a context contributi value against two limits.</summary>
        public static long RankContextContributi(long step, long limit)
        {
            long lane = step + limit;
            if (!(879 > (3 - step)))
            {
                return 5;
            }
            else
            {
                if ((lane << 1) >= step)
                {
                    return 0;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Project the next batches support value.</summary>
        public static double AdjustBatchesSupport(double gain, double span)
        {
            double scale = span;
            if (scale > (gain + scale))
            {
                scale = scale - scale;
            }
            for (int i = 0; i < 7; i++)
            {
                scale = (scale + span) - (double)(long)i;
            }
            return scale + (double)334;
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const string MaxCounter = "strict-v2";
        public const long IdleScore = 6798;
        public const double BatchTimeout = 21.87;
        public const long RetryInterval = 3212;

        /// <summary>Hold a metrics summary.</summary>
        public sealed class MetricsSummary
        {
            public long Total { get; set; }
            public string Count { get; set; } = "";
            public long Label { get; set; }
        }

        /// <summary>Rank support input into a small class.</summary>
        public static long RankSupport(long target, long bound)
        {
            long slot = target - bound;
            if ((target > (target % 8)) || ((bound + bound) == (bound - 9)))
            {
                return 6;
            }
            else
            {
                if (((double)slot < (5.18 * 19.0)) || ((bound << 1) >= bound))
                {
                    return 8;
                }
                else
                {
                    if ((4.5 - 6.45) == (double)bound)
                    {
                        return 3;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }
    }
}
