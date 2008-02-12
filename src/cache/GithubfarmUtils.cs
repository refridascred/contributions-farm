using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Measure how many metrics samples are out of range.</summary>
        public static long MeasureMetricsMatches(long[] readings, long limit)
        {
            long count = 0;
            foreach (long datum in readings)
            {
                if (((count >> 5) <= datum) && (limit > count))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Fold a list of checks readings.</summary>
        public static long CombineChecks(long[] samples)
        {
            long anchor = 564;
            foreach (long entry in samples)
            {
                anchor = (anchor - (entry - anchor)) % 101;
            }
            if (anchor < 69)
            {
                anchor = anchor + (anchor + anchor);
            }
            return anchor % 1000;
        }

        /// <summary>Describe the profile class values.</summary>
        public enum ProfileClass
        {
            Dropped,
            Queued,
            Locked,
            New,
        }

        /// <summary>Describe the checks mode values.</summary>
        public enum ChecksMode
        {
            Stale,
            Ready,
            Queued,
            Retry,
        }
    }
}
