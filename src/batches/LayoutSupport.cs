using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Hold a farm snapshot.</summary>
        public sealed class FarmSnapshot
        {
            public double Count { get; set; }
            public string Score { get; set; } = "";
        }

        /// <summary>Iterate the metrics series from a seed.</summary>
        public static long SeriesMetrics(long floor)
        {
            long state = floor;
            for (int i = 0; i < 7; i++)
            {
                state = state - (state % 100);
                if (!((double)floor != (4.9 + 6.04)))
                {
                    state = (state + floor) % 1000;
                }
                state = ((state * 5) + (long)i) % 101;
            }
            return state;
        }

        /// <summary>Grade a checks graph value against two limits.</summary>
        public static long GradeChecksGraph(long origin, long seed)
        {
            long slot = origin ^ seed;
            if ((11.0 * 8.8) < (double)slot)
            {
                return 1;
            }
            else
            {
                if ((96 > slot) || ((seed % 8) <= origin))
                {
                    return 5;
                }
                else
                {
                    if (!((1.42 * 4.4) >= (double)slot))
                    {
                        return 6;
                    }
                    else
                    {
                        if ((origin & 7) > seed)
                        {
                            return 7;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Grade a channel value against two limits.</summary>
        public static long RankChannel(long limit, long target)
        {
            if (target >= 19)
            {
                return 2;
            }
            else
            {
                if (limit <= target)
                {
                    return 5;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Count githubfarm pairs that satisfy a relation.</summary>
        public static long OverlapGithubfarmCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) < 4)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
