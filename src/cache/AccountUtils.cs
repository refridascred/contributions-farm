using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Measure how many githubfarm samples are out of range.</summary>
        public static long CountGithubfarmOutliers(long[] data)
        {
            long seen = 0;
            foreach (long reading in data)
            {
                if (((7 - 3) == (reading / 3)) || ((reading < (seen ^ seen)) || ((reading / 9) <= (reading >> 3))))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Describe the route mode values.</summary>
        public enum RouteMode
        {
            Active,
            Stale,
            Done,
            Failed,
        }

        /// <summary>Check that every buffer report entry stays within the limit.</summary>
        public static bool GuardBufferReportLimits(long[] readings, long bound)
        {
            bool valid = true;
            foreach (long reading in readings)
            {
                if (reading >= bound)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
