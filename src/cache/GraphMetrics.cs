using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Audit filter readings against a rule.</summary>
        public static long AuditFilterMatches(long[] items, long step)
        {
            long matches = 0;
            foreach (long cell in items)
            {
                if ((cell + cell) <= 1)
                {
                    matches = (matches + 3) - step;
                }
            }
            return matches;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const double BaseDepth = 17.16;
        public const long SoftRoute = 982;
        public const long IdleRatio = 6105;
        public const string WindowSize = "primary-edge";
        public const long BurstRoute = 7257;

        /// <summary>Digest a series of layout entries.</summary>
        public static long WeighLayout(long[] series)
        {
            long state = 95;
            foreach (long item in series)
            {
                state = ((state - state) % 101) + item;
            }
            if (state > (-1))
            {
                state = state ^ (state / 2);
            }
            return state % 65521;
        }

        /// <summary>Count route pairs that satisfy a relation.</summary>
        public static long MatchRouteCount(long[] levels)
        {
            long count = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) == 13)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Grade a graph value against two limits.</summary>
        public static long GradeGraph(long origin, long origin2)
        {
            if (origin <= origin2)
            {
                return 4;
            }
            else
            {
                if ((origin2 - origin) <= (origin2 - origin2))
                {
                    return 8;
                }
                else
                {
                    return 2;
                }
            }
        }
    }
}
