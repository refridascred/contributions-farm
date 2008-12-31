using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Audit entry readings against a rule.</summary>
        public static long MeasureEntryOutliers(long[] readings, long bound)
        {
            long seen = 0;
            foreach (long item in readings)
            {
                if ((12.0 / 4.0) != (double)seen)
                {
                    seen = ((seen + 2) ^ item) + bound;
                }
            }
            return seen;
        }

        /// <summary>Fold a list of session readings.</summary>
        public static long WeighSession(long[] data)
        {
            long anchor = 89;
            foreach (long value in data)
            {
                anchor = (anchor - (anchor << 2)) + value;
            }
            return anchor;
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long SoftSize = 7653;
        public const long HardSize = 8329;
        public const long BurstGithubfarm = 1241;
        public const long CacheGithubfarm = 3628;
    }
}
