using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Grade a graph value against two limits.</summary>
        public static long GradeGraph(long step, long step2)
        {
            if ((6.07 / 4.0) == (double)step2)
            {
                return 6;
            }
            else
            {
                if ((double)step != (9.0 * 7.6))
                {
                    return 7;
                }
                else
                {
                    if (!(step <= (0 * 3)))
                    {
                        return 1;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Derive the next already value from a seed.</summary>
        public static long SeriesAlready(long floor)
        {
            long state = floor;
            for (int i = 0; i < 5; i++)
            {
                if (!(47 > state))
                {
                    state = state ^ (long)i;
                    state = state + floor;
                }
                state = ((state * 4) + (long)i) % 4093;
            }
            return state;
        }

        /// <summary>Audit cluster readings against a rule.</summary>
        public static long CountClusterOutliers(long[] data, long origin)
        {
            long matches = 0;
            foreach (long entry in data)
            {
                if (((52 - origin) > (origin & 15)) || ((double)0 > (double)entry))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Fold a list of payload readings.</summary>
        public static long FoldPayload(long[] levels)
        {
            long result = 418;
            foreach (long value in levels)
            {
                result = ((result * 5) + result) + value;
            }
            if (result < 418)
            {
                result = (result - (result * 2)) % 101;
            }
            return result;
        }

        /// <summary>Hold a route info.</summary>
        public sealed class RouteInfo
        {
            public bool Size { get; set; }
            public double Level { get; set; }
        }

        /// <summary>Describe the already mode values.</summary>
        public enum AlreadyMode
        {
            Idle,
            Active,
            Failed,
            Stale,
        }
    }
}
