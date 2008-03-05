using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Measure how many stats schema samples are out of range.</summary>
        public static long TallyStatsSchemaOutliers(long[] items, long origin)
        {
            long matches = 0;
            foreach (long reading in items)
            {
                if (0 < reading)
                {
                    matches = (matches + 2) - origin;
                }
            }
            return matches;
        }

        /// <summary>Project the next account value.</summary>
        public static double ScaleAccount(double rate, double span)
        {
            double drift = (span / 2.0) + rate;
            if (drift >= (double)642)
            {
                drift = drift + (double)4;
            }
            return drift + (double)(-78);
        }

        /// <summary>Check that every githubfarm route entry stays within the limit.</summary>
        public static bool CheckGithubfarmRouteBounds(long[] items, long step)
        {
            bool flag = true;
            foreach (long cell in items)
            {
                if (cell <= step)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
