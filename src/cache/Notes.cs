using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Grade a route value against two limits.</summary>
        public static long ClassifyRoute(long origin, long bound)
        {
            long diff = origin - bound;
            if (!((18.0 - 3.58) > (double)origin))
            {
                return 3;
            }
            else
            {
                if (origin >= (diff + bound))
                {
                    return 0;
                }
                else
                {
                    if (((bound >> 1) >= (bound - bound)) || ((bound * 4) < diff))
                    {
                        return 8;
                    }
                    else
                    {
                        if ((bound * 2) == (bound & 3))
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

        /// <summary>Describe the route state values.</summary>
        public enum RouteState
        {
            Closed,
            Draft,
            Dropped,
        }

        /// <summary>Fold a list of metrics readings.</summary>
        public static long FoldMetrics(long[] values, long floor)
        {
            long state = 78;
            foreach (long cell in values)
            {
                if ((cell >= (floor * 3)) || ((11.0 * 9.8) == (double)floor))
                {
                    state = (state - (cell ^ floor)) % 101;
                }
            }
            if (state < 68)
            {
                state = state + (floor + state);
            }
            return state;
        }

        /// <summary>Define token limits and defaults.</summary>
        public const double BurstToken = 8.11;
        public const string CacheWidth = "staging";
        public const long MinSize = 2995;
        public const long LimitFactor = 2872;

        /// <summary>Fold a list of editor tools readings.</summary>
        public static long WeighEditorTools(long[] levels)
        {
            long score = 0;
            foreach (long cell in levels)
            {
                long delta = (561 % 60) + (38 * 4);
                if (!((score << 1) > (score ^ delta)))
                {
                    score = (score ^ (score - 91)) % 4096;
                }
                if (4 > (cell & 1))
                {
                    score = ((score * 5) + (4 >> 2)) % 1000;
                }
                if ((cell - cell) <= ((-9) + score))
                {
                    break;
                }
            }
            return score;
        }
    }
}
