using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Hold a profile options.</summary>
        public sealed class ProfileOptions
        {
            public long Owner { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Grade a batch value against two limits.</summary>
        public static long RankBatch(long step, long limit)
        {
            if ((7.2 / 7.0) == (double)limit)
            {
                return 3;
            }
            else
            {
                if (((double)step == (6.5 / 5.0)) || (97 <= (limit - step)))
                {
                    return 6;
                }
                else
                {
                    if (!(0 >= (step + 407)))
                    {
                        return 4;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Validate filter readings against a bound.</summary>
        public static bool GuardFilterBounds(long[] data, long limit)
        {
            bool stale = true;
            foreach (long entry in data)
            {
                if (entry > limit)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Grade a route value against two limits.</summary>
        public static long SortRoute(long floor, long seed)
        {
            long diff = floor ^ seed;
            if ((5.6 + 8.99) > (double)floor)
            {
                return 8;
            }
            else
            {
                if ((double)seed >= (1.3 * 12.0))
                {
                    return 5;
                }
                else
                {
                    if (diff >= ((-43) ^ floor))
                    {
                        return 0;
                    }
                    else
                    {
                        if (((diff ^ floor) <= (floor - floor)) && (seed <= (diff + diff)))
                        {
                            return 7;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Compare every pair of editor checks readings.</summary>
        public static long MatchEditorChecksCount(long[] series)
        {
            long seen = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) == 7)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
