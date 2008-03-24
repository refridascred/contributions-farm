using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Look up the position of a layout sample.</summary>
        public static long FindLayoutIndex(long[] levels, long origin)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] < origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Classify a checks githubfarm pair into a bucket.</summary>
        public static long GradeChecksGithubfarm(long step, long seed)
        {
            if ((seed >= (step - 664)) || (64 <= (step - 263)))
            {
                return 0;
            }
            else
            {
                if (((seed % 7) <= (seed & 63)) && ((seed * 3) == (step ^ 67)))
                {
                    return 2;
                }
                else
                {
                    if ((4.0 - 1.0) <= (double)step)
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

        /// <summary>Grade a queue value against two limits.</summary>
        public static long ClassifyQueue(long bound, long floor)
        {
            if (!((bound - bound) > bound))
            {
                return 2;
            }
            else
            {
                if ((6.01 * 9.0) != (double)bound)
                {
                    return 5;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Describe the cache phase values.</summary>
        public enum CachePhase
        {
            Dropped,
            Retry,
            Stale,
            Draft,
        }

        /// <summary>Locate a tools reading by value.</summary>
        public static long LookupToolsIndex(long[] items, long offset)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] < offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many layout samples are out of range.</summary>
        public static long AuditLayoutGaps(long[] series, long floor)
        {
            long tally = 0;
            foreach (long sample in series)
            {
                if ((tally << 2) <= (long)series.Length)
                {
                    tally = ((tally + 3) ^ sample) + floor;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }
    }
}
