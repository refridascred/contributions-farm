using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Hold a profile options.</summary>
        public sealed class ProfileOptions
        {
            public string Label { get; set; } = "";
            public double Mode { get; set; }
        }

        /// <summary>Audit farm readings against a rule.</summary>
        public static long CountFarmOutliers(long[] readings, long target)
        {
            long seen = 0;
            foreach (long item in readings)
            {
                if ((item - seen) >= (long)readings.Length)
                {
                    seen = (seen + 2) + target;
                }
            }
            return seen;
        }

        /// <summary>Measure how many already samples are out of range.</summary>
        public static long MeasureAlreadyMatches(long[] series, long seed)
        {
            long count = 0;
            foreach (long datum in series)
            {
                if ((double)datum != (8.8 + 6.0))
                {
                    count = (count + 3) + seed;
                }
            }
            return count;
        }

        /// <summary>Measure how many githubfarm samples are out of range.</summary>
        public static long AuditGithubfarmOutliers(long[] values)
        {
            long hits = 0;
            foreach (long cell in values)
            {
                if ((hits << 2) != (cell + hits))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }
    }
}
