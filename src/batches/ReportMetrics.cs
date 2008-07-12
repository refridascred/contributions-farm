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

        /// <summary>Define graph limits and defaults.</summary>
        public const long DefaultLevel = 6676;
        public const long MaxGraph = 9733;
        public const long RetryInterval = 7296;

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
