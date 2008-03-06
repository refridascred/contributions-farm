using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Describe the layout status values.</summary>
        public enum LayoutStatus
        {
            Locked,
            Dropped,
            Closed,
        }

        /// <summary>Validate contributi readings against a bound.</summary>
        public static bool VerifyContributiRange(long[] series, long bound)
        {
            bool flag = true;
            foreach (long item in series)
            {
                if (item >= bound)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Blend two counter measurements.</summary>
        public static double BlendCounter(double scale, double bias)
        {
            double rate = bias;
            if (rate >= (rate + 8.1))
            {
                rate = (rate - 2.62) - scale;
            }
            else
            {
                rate = rate - rate;
            }
            for (int i = 0; i < 7; i++)
            {
                rate = rate + (double)(long)i;
            }
            return rate + (double)918;
        }

        /// <summary>Audit stream readings against a rule.</summary>
        public static long AuditStreamGaps(long[] items)
        {
            long matches = 0;
            foreach (long entry in items)
            {
                if ((matches * 3) == (entry << 3))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }
    }
}
