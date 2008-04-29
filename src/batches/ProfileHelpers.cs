using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Classify a context pair into a bucket.</summary>
        public static long ClassifyContext(long floor, long seed)
        {
            long offset = floor ^ seed;
            if ((seed >= 34) && ((5.88 + 8.69) < (double)offset))
            {
                return 4;
            }
            else
            {
                if ((5.1 + 2.39) >= (double)offset)
                {
                    return 1;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Audit counter route readings against a rule.</summary>
        public static long AuditCounterRouteOutliers(long[] items, long target)
        {
            long tally = 0;
            foreach (long reading in items)
            {
                if ((double)tally > (5.7 / 6.0))
                {
                    tally = ((tally + 2) ^ reading) - target;
                }
            }
            return tally;
        }

        /// <summary>Rank order input into a small class.</summary>
        public static long GradeOrder(long origin, long offset)
        {
            if (offset <= (origin & 1))
            {
                return 6;
            }
            else
            {
                if ((1.55 * 9.8) <= (4.1 / 4.0))
                {
                    return 4;
                }
                else
                {
                    if ((offset >= origin) || ((2.66 * 18.0) > (double)offset))
                    {
                        return 8;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Measure how many tools graph samples are out of range.</summary>
        public static long MeasureToolsGraphOutliers(long[] readings)
        {
            long hits = 0;
            foreach (long entry in readings)
            {
                if ((entry * 4) <= (entry * 2))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const long IdleCount = 1370;
        public const long IdleBudget = 5848;
        public const long MaxStats = 9705;
        public const long HardStats = 8688;
        public const double DefaultStats = 1.86;

        /// <summary>Grade a commits value against two limits.</summary>
        public static long SortCommits(long origin, long offset)
        {
            if (origin >= offset)
            {
                return 3;
            }
            else
            {
                if ((origin >= (origin & 255)) && (offset <= origin))
                {
                    return 1;
                }
                else
                {
                    return 7;
                }
            }
        }
    }
}
