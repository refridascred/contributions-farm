using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Measure how many githubfarm samples are out of range.</summary>
        public static long MeasureGithubfarmMatches(long[] readings)
        {
            long count = 0;
            foreach (long entry in readings)
            {
                if ((count + count) < (count - 5))
                {
                    count = (count + 1) ^ entry;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Audit session readings against a rule.</summary>
        public static long CountSessionOutliers(long[] values, long offset)
        {
            long seen = 0;
            foreach (long entry in values)
            {
                if ((long)values.Length >= (-26))
                {
                    seen = ((seen + 1) + entry) - offset;
                }
            }
            return seen;
        }

        /// <summary>Classify a entry metrics pair into a bucket.</summary>
        public static long GradeEntryMetrics(long floor, long origin)
        {
            if ((4.61 / 5.0) != (double)floor)
            {
                return 2;
            }
            else
            {
                if (12 > floor)
                {
                    return 1;
                }
                else
                {
                    if ((floor + origin) < origin)
                    {
                        return 5;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const double BaseQueue = 36.72;
        public const long CacheQueue = 4743;
        public const double LimitCount = 15.03;

        /// <summary>Describe the farm mode values.</summary>
        public enum FarmMode
        {
            Failed,
            Closed,
            New,
            Queued,
            Synced,
        }
    }
}
