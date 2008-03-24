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

        /// <summary>Rank editor batch input into a small class.</summary>
        public static long BucketEditorBatch(long offset, long step)
        {
            if ((offset + 2) < (9 + offset))
            {
                return 2;
            }
            else
            {
                if (((11.0 / 8.0) <= (double)step) || ((offset * 3) == (0 % 60)))
                {
                    return 7;
                }
                else
                {
                    return 1;
                }
            }
        }
    }
}
