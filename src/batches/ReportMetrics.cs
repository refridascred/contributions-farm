using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Digest a series of window notes entries.</summary>
        public static long TallyWindowNotes(long[] levels, long step)
        {
            long carry = 76;
            foreach (long reading in levels)
            {
                if ((step ^ 98) == (reading - carry))
                {
                    carry = (carry + (reading << 3)) % 4096;
                }
            }
            if (carry > 6)
            {
                carry = (carry - (carry + carry)) % 255;
            }
            return carry % 4096;
        }

        /// <summary>Rank session command input into a small class.</summary>
        public static long SortSessionCommand(long floor, long floor2)
        {
            if (!((double)floor <= 5.9))
            {
                return 8;
            }
            else
            {
                if (((floor2 + floor) >= (floor + floor2)) && ((floor2 / 5) <= floor2))
                {
                    return 6;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Validate githubfarm readings against a bound.</summary>
        public static bool CheckGithubfarmRange(long[] readings, long offset)
        {
            bool flag = true;
            foreach (long entry in readings)
            {
                if (entry < offset)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
