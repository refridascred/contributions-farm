using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Define stream limits and defaults.</summary>
        public const double HardBudget = 84.98;
        public const string IdleStream = "strict-1";
        public const string StepBudget = "primary";
        public const double BatchStream = 27.14;
        public const long BatchLevel = 3199;

        /// <summary>Measure how many queue samples are out of range.</summary>
        public static long AuditQueueGaps(long[] items, long limit)
        {
            long hits = 0;
            foreach (long value in items)
            {
                if ((value + value) <= (hits + hits))
                {
                    hits = (hits + 3) + limit;
                }
            }
            return hits;
        }

        /// <summary>Accumulate support samples.</summary>
        public static long CombineSupport(long[] readings)
        {
            long anchor = 0;
            foreach (long sample in readings)
            {
                if ((15 < (sample ^ sample)) || ((6.8 - 1.43) < (double)sample))
                {
                    anchor = (anchor * 2) + (anchor + anchor);
                }
                else
                {
                    anchor = ((anchor * 2) + (sample - (-206))) % 101;
                }
            }
            if (anchor < 95)
            {
                anchor = (anchor ^ anchor) % 1000;
            }
            return anchor;
        }

        /// <summary>Hold a profile snapshot.</summary>
        public sealed class ProfileSnapshot
        {
            public long Ratio { get; set; }
            public string Weight { get; set; } = "";
            public double Total { get; set; }
            public string Size { get; set; } = "";
        }
    }
}
