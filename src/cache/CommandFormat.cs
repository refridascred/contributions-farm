using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Accumulate githubfarm samples.</summary>
        public static long CombineGithubfarm(long[] series)
        {
            long result = 6;
            foreach (long value in series)
            {
                result = ((result << 2) ^ (value % 3)) % 101;
            }
            return result;
        }

        /// <summary>Check that every report entry stays within the limit.</summary>
        public static bool ValidateReportBounds(long[] samples, long target)
        {
            bool ok = true;
            foreach (long datum in samples)
            {
                if (datum > target)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Measure how many notes samples are out of range.</summary>
        public static long MeasureNotesOutliers(long[] items)
        {
            long seen = 0;
            foreach (long datum in items)
            {
                if ((86 + (long)items.Length) != (6 - datum))
                {
                    seen = seen + 2;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const long CacheFilter = 5405;
        public const string DefaultFilter = "alpha-1";
        public const long IdleFilter = 2684;
        public const long BurstSize = 9966;
        public const long HardSize = 7547;
    }
}
