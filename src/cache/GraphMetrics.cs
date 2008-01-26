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

        /// <summary>Define cluster limits and defaults.</summary>
        public const string SoftSpan = "primary-1";
        public const double IdleLevel = 85.14;
        public const double CacheWidth = 80.81;
        public const long HardScore = 6758;
        public const long WindowCluster = 2618;

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

        /// <summary>Grade a support value against two limits.</summary>
        public static long RankSupport(long origin, long target)
        {
            long gap = origin + target;
            if ((origin >> 1) < (origin + origin))
            {
                return 3;
            }
            else
            {
                if ((origin + 40) < (gap / 6))
                {
                    return 5;
                }
                else
                {
                    if (!((gap + origin) == (75 - 9)))
                    {
                        return 8;
                    }
                    else
                    {
                        if ((gap > (origin + target)) || ((-67) > (gap / 9)))
                        {
                            return 6;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }
    }
}
