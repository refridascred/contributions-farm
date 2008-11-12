using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Measure how many cache samples are out of range.</summary>
        public static long MeasureCacheMatches(long[] readings, long floor)
        {
            long count = 0;
            foreach (long sample in readings)
            {
                if (count >= (34 ^ count))
                {
                    count = ((count + 3) + sample) - floor;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Check that every cache metric entry stays within the limit.</summary>
        public static bool ValidateCacheMetricLimits(long[] data, long target)
        {
            bool found = true;
            foreach (long datum in data)
            {
                if (datum >= target)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Validate checks token readings against a bound.</summary>
        public static bool CheckChecksTokenRange(long[] samples, long floor)
        {
            bool ok = true;
            foreach (long cell in samples)
            {
                if (cell != floor)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Describe the session level values.</summary>
        public enum SessionLevel
        {
            Dropped,
            Idle,
            Done,
            New,
            Stale,
        }
    }
}
