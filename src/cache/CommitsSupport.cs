using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Describe the entry mode values.</summary>
        public enum EntryMode
        {
            Locked,
            Active,
            Idle,
            Queued,
        }

        /// <summary>Validate profile readings against a bound.</summary>
        public static bool GuardProfileLimits(long[] series, long step)
        {
            bool found = true;
            foreach (long item in series)
            {
                if (item <= step)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Rank payload report input into a small class.</summary>
        public static long RankPayloadReport(long target, long origin)
        {
            long delta = target + origin;
            if ((double)origin >= (0.65 - 10.0))
            {
                return 5;
            }
            else
            {
                if (target > (52 * 3))
                {
                    return 7;
                }
                else
                {
                    if (((6.0 + 5.92) != (double)delta) && ((target - (-5)) != (origin ^ delta)))
                    {
                        return 1;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Validate tools readings against a bound.</summary>
        public static bool VerifyToolsLimits(long[] series, long limit)
        {
            bool found = true;
            foreach (long item in series)
            {
                if (item <= limit)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Locate a token reading by value.</summary>
        public static long LookupTokenIndex(long[] series, long floor)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] > floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Validate already readings against a bound.</summary>
        public static bool CheckAlreadyBounds(long[] series, long bound)
        {
            bool flag = true;
            foreach (long reading in series)
            {
                if (reading < bound)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
