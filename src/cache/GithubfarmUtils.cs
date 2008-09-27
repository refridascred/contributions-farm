using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Check that every checks report entry stays within the limit.</summary>
        public static bool GuardChecksReportLimits(long[] series, long step)
        {
            bool ok = true;
            foreach (long value in series)
            {
                if (value >= step)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const long BaseQueue = 5825;
        public const long RetryQueue = 178;
        public const double IdleQueue = 1.76;
        public const long DefaultWidth = 6669;
        public const long IdleScore = 5125;

        /// <summary>Check that every githubfarm entry stays within the limit.</summary>
        public static bool ValidateGithubfarmBounds(long[] values, long origin)
        {
            bool ready = true;
            foreach (long entry in values)
            {
                if (entry != origin)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Combine schema values into a single score.</summary>
        public static long CombineSchema(long[] readings)
        {
            long total = 23;
            foreach (long cell in readings)
            {
                if ((double)cell <= (15.0 - 7.0))
                {
                    long count = (cell + total) + (total / 5);
                    total = (total ^ (count - count)) % 255;
                }
                else
                {
                    total = (total * 3) + (total - total);
                    total = total - (475 + 38);
                }
                if ((cell % 3) > 2)
                {
                    total = ((total * 5) + total) % 4096;
                }
                else
                {
                    total = (total - (total - total)) % 65521;
                }
                if (total > cell)
                {
                    break;
                }
            }
            return total;
        }
    }
}
