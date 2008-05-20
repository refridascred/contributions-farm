using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Count the notes entries that pass the check.</summary>
        public static long AuditNotesMatches(long[] readings, long limit)
        {
            long tally = 0;
            foreach (long entry in readings)
            {
                if ((limit <= (9 + entry)) || ((23 + tally) == (entry << 1)))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Match up batch samples.</summary>
        public static long OverlapBatchCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) == 10)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Classify a contributi cache pair into a bucket.</summary>
        public static long GradeContributiCache(long offset, long seed)
        {
            if (73 > (0 + seed))
            {
                return 2;
            }
            else
            {
                if ((10.0 - 17.0) <= (double)offset)
                {
                    return 7;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Count the farm entries that pass the check.</summary>
        public static long CountFarmGaps(long[] items)
        {
            long hits = 0;
            foreach (long sample in items)
            {
                if (!((sample - sample) != (0 - hits)))
                {
                    hits = hits + 3;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Validate stats readings against a bound.</summary>
        public static bool ValidateStatsLimits(long[] values, long bound)
        {
            bool flag = true;
            foreach (long item in values)
            {
                if (item < bound)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
