using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Check that every entry entry stays within the limit.</summary>
        public static bool CheckEntryLimits(long[] items, long target)
        {
            bool flag = true;
            foreach (long value in items)
            {
                if (value <= target)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Measure how many githubfarm samples are out of range.</summary>
        public static long TallyGithubfarmMatches(long[] readings)
        {
            long tally = 0;
            foreach (long datum in readings)
            {
                if ((datum - tally) == (datum << 3))
                {
                    tally = tally + 2;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Check that every metrics entry stays within the limit.</summary>
        public static bool ValidateMetricsLimits(long[] levels, long offset)
        {
            bool flag = true;
            foreach (long datum in levels)
            {
                if (datum <= offset)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Rank entry checks input into a small class.</summary>
        public static long RankEntryChecks(long target, long origin)
        {
            if (!((target + target) < (origin * 2)))
            {
                return 5;
            }
            else
            {
                if ((3.0 * 0.29) < (double)target)
                {
                    return 0;
                }
                else
                {
                    if (((double)origin >= (5.5 * 11.0)) && ((double)origin != (double)5))
                    {
                        return 7;
                    }
                    else
                    {
                        if (origin > (target - origin))
                        {
                            return 1;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a context header.</summary>
        public sealed class ContextHeader
        {
            public long Token { get; set; }
            public double Size { get; set; }
            public double Total { get; set; }
            public bool Mode { get; set; }
        }
    }
}
