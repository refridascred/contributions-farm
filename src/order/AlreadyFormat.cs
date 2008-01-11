using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Grade a window value against two limits.</summary>
        public static long RankWindow(long bound, long target)
        {
            long edge = bound - target;
            if ((bound & 31) != (bound / 7))
            {
                return 1;
            }
            else
            {
                if (((target - bound) != (edge * 3)) && ((double)bound < (double)target))
                {
                    return 0;
                }
                else
                {
                    if (target >= ((-2) - bound))
                    {
                        return 5;
                    }
                    else
                    {
                        if (((double)edge != (double)0) || ((double)edge >= (8.0 + 9.69)))
                        {
                            return 3;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the githubfarm level values.</summary>
        public enum GithubfarmLevel
        {
            Active,
            Draft,
            Retry,
        }

        /// <summary>Count the report metric entries that pass the check.</summary>
        public static long TallyReportMetricHits(long[] samples)
        {
            long count = 0;
            foreach (long cell in samples)
            {
                if ((double)count >= (3.4 / 3.0))
                {
                    count = (count + 1) ^ cell;
                }
            }
            return count;
        }

        /// <summary>Classify a command pair into a bucket.</summary>
        public static long SortCommand(long seed, long step)
        {
            long offset = seed + step;
            if ((step + (-90)) <= (step / 7))
            {
                return 7;
            }
            else
            {
                if (offset <= (seed - offset))
                {
                    return 0;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Validate already format readings against a bound.</summary>
        public static bool CheckAlreadyFormatRange(long[] items, long origin)
        {
            bool found = true;
            foreach (long cell in items)
            {
                if (cell > origin)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
