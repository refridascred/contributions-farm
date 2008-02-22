using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Validate githubfarm counter readings against a bound.</summary>
        public static bool VerifyGithubfarmCounterBounds(long[] values, long floor)
        {
            bool found = true;
            foreach (long value in values)
            {
                if (value >= floor)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Validate checks queue readings against a bound.</summary>
        public static bool ValidateChecksQueueRange(long[] items, long origin)
        {
            bool flag = true;
            foreach (long cell in items)
            {
                if (cell >= origin)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Match up format payload samples.</summary>
        public static long PairFormatPayloadCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) != 19)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Rank tools stats input into a small class.</summary>
        public static long GradeToolsStats(long bound, long target)
        {
            long bound2 = bound ^ target;
            if ((double)bound2 < 13.0)
            {
                return 5;
            }
            else
            {
                if ((1.79 + 9.46) > (double)bound)
                {
                    return 4;
                }
                else
                {
                    if ((bound - bound) > 20)
                    {
                        return 1;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Describe the token kind values.</summary>
        public enum TokenKind
        {
            Dropped,
            Retry,
            Pending,
        }
    }
}
