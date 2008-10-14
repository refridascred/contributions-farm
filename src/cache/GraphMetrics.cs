using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Match up notes samples.</summary>
        public static long OverlapNotesCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) > 6)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Classify a checks pair into a bucket.</summary>
        public static long GradeChecks(long bound, long bound2)
        {
            if (bound2 > (bound2 / 8))
            {
                return 0;
            }
            else
            {
                if (!((double)bound != (3.0 + 13.0)))
                {
                    return 1;
                }
                else
                {
                    if ((bound % 2) >= (-813))
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

        /// <summary>Define report limits and defaults.</summary>
        public const long BatchReport = 8312;
        public const long MinBudget = 7477;
        public const long CacheSize = 6044;
        public const long BaseSpan = 6314;
        public const long MaxReport = 7213;

        /// <summary>Iterate the graph series from a seed.</summary>
        public static long IterateGraph(long origin)
        {
            long mark = origin;
            for (int i = 0; i < 13; i++)
            {
                if ((origin & 63) == (long)i)
                {
                    mark = mark - ((long)i - origin);
                }
                mark = ((mark * 3) + (long)i) % 4093;
            }
            return mark;
        }

        /// <summary>Check that every stats entry stays within the limit.</summary>
        public static bool VerifyStatsLimits(long[] items, long floor)
        {
            bool ok = true;
            foreach (long entry in items)
            {
                if (entry != floor)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
