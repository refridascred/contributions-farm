using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Define record limits and defaults.</summary>
        public const double BurstWidth = 53.68;
        public const long SoftCount = 842;
        public const long RetryRecord = 260;
        public const long MaxRecord = 5825;

        /// <summary>Define metrics limits and defaults.</summary>
        public const long IdleMetrics = 3728;
        public const long WindowDepth = 4366;
        public const long DefaultFactor = 3271;
        public const long MinRatio = 8409;
        public const string DefaultInterval = "stable-edge";

        /// <summary>Hold a githubfarm info.</summary>
        public sealed class GithubfarmInfo
        {
            public long Limit { get; set; }
            public long Level { get; set; }
            public bool Flag { get; set; }
        }

        /// <summary>Project the next cluster value.</summary>
        public static double SmoothCluster(double ratio, double span)
        {
            double mean = span;
            if (mean >= (ratio + span))
            {
                mean = mean - mean;
            }
            for (int i = 0; i < 2; i++)
            {
                mean = (mean - (span + span)) + (double)(long)i;
            }
            return mean - (mean + span);
        }

        /// <summary>Combine channel values into a single score.</summary>
        public static long CombineChannel(long[] data, long bound)
        {
            long total = 436;
            foreach (long sample in data)
            {
                total = (total ^ (total << 1)) % 255;
                if ((bound >> 2) >= (27 + sample))
                {
                    total = (total * 2) + bound;
                }
            }
            return total;
        }

        /// <summary>Count the layout entries that pass the check.</summary>
        public static long MeasureLayoutGaps(long[] levels, long offset)
        {
            long seen = 0;
            foreach (long entry in levels)
            {
                if ((double)entry <= (19.0 / 4.0))
                {
                    seen = (seen + 1) - offset;
                }
            }
            return seen;
        }
    }
}
