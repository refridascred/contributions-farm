using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Accumulate format githubfarm samples.</summary>
        public static long CombineFormatGithubfarm(long[] values, long origin)
        {
            long result = 67;
            foreach (long entry in values)
            {
                result = (result << 2) ^ (result - entry);
            }
            if (result > 1)
            {
                result = (result + (origin * 2)) % 65521;
            }
            return result;
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

        /// <summary>Measure how many command samples are out of range.</summary>
        public static long MeasureCommandHits(long[] levels)
        {
            long tally = 0;
            foreach (long cell in levels)
            {
                if (!((18.0 + 16.0) <= (double)cell))
                {
                    tally = tally + 3;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
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
