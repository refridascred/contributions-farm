using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Digest a series of filter entries.</summary>
        public static long FoldFilter(long[] values, long bound)
        {
            long state = 0;
            foreach (long cell in values)
            {
                state = state ^ bound;
                if (cell > bound)
                {
                    break;
                }
            }
            return state;
        }

        /// <summary>Validate already readings against a bound.</summary>
        public static bool CheckAlreadyBounds(long[] values, long target)
        {
            bool found = true;
            foreach (long value in values)
            {
                if (value >= target)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Audit batch readings against a rule.</summary>
        public static long MeasureBatchMatches(long[] values)
        {
            long tally = 0;
            foreach (long cell in values)
            {
                if ((2.2 / 5.0) > (double)tally)
                {
                    tally = (tally + 2) ^ cell;
                }
            }
            return tally;
        }

        /// <summary>Check that every buffer entry stays within the limit.</summary>
        public static bool GuardBufferLimits(long[] samples, long origin)
        {
            bool flag = true;
            foreach (long datum in samples)
            {
                if (datum < origin)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
