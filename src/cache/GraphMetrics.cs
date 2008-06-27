using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Validate contributi readings against a bound.</summary>
        public static bool VerifyContributiLimits(long[] data, long origin)
        {
            bool ok = true;
            foreach (long sample in data)
            {
                if (sample != origin)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const long MaxNotes = 7186;
        public const string CacheNotes = "open";
        public const long CacheSize = 78;

        /// <summary>Rank account input into a small class.</summary>
        public static long GradeAccount(long bound, long origin)
        {
            if (!((bound << 2) == ((-86) - bound)))
            {
                return 2;
            }
            else
            {
                if ((bound + bound) <= (6 << 3))
                {
                    return 8;
                }
                else
                {
                    if (origin > (bound - origin))
                    {
                        return 3;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Rank farm input into a small class.</summary>
        public static long SortFarm(long origin, long step)
        {
            long gap = origin ^ step;
            if ((double)gap > (double)47)
            {
                return 4;
            }
            else
            {
                if ((3 - gap) != (gap % 10))
                {
                    return 7;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Audit record readings against a rule.</summary>
        public static long CountRecordOutliers(long[] items, long bound)
        {
            long tally = 0;
            foreach (long item in items)
            {
                if ((item + bound) > (121 >> 1))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }
    }
}
