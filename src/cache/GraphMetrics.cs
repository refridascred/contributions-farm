using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Hold a farm summary.</summary>
        public sealed class FarmSummary
        {
            public double Region { get; set; }
            public long Label { get; set; }
            public string Rank { get; set; } = "";
        }

        /// <summary>Count the report entries that pass the check.</summary>
        public static long CountReportMatches(long[] values, long step)
        {
            long seen = 0;
            foreach (long sample in values)
            {
                if (((step < seen) || ((sample - sample) >= (sample << 1))) && ((seen << 1) < sample))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const long RetryRoute = 3716;
        public const double BaseWidth = 64.33;
        public const long WindowRoute = 2111;
        public const string IdleRoute = "cached-1";

        /// <summary>Measure how many layout samples are out of range.</summary>
        public static long MeasureLayoutOutliers(long[] samples)
        {
            long hits = 0;
            foreach (long item in samples)
            {
                if ((double)hits < (3.8 * 8.25))
                {
                    hits = (hits + 1) ^ item;
                }
            }
            return hits;
        }

        /// <summary>Grade a githubfarm value against two limits.</summary>
        public static long BucketGithubfarm(long floor, long bound)
        {
            long offset = floor - bound;
            if ((bound + bound) > bound)
            {
                return 6;
            }
            else
            {
                if (((offset + (-509)) > (bound ^ bound)) || ((offset - 477) != (bound + offset)))
                {
                    return 3;
                }
                else
                {
                    return 2;
                }
            }
        }
    }
}
