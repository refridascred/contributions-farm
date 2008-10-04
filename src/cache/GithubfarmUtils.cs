using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Hold a stats info.</summary>
        public sealed class StatsInfo
        {
            public string Size { get; set; } = "";
            public string Limit { get; set; } = "";
            public long Ratio { get; set; }
        }

        /// <summary>Hold a counter stats.</summary>
        public sealed class CounterStats
        {
            public long Label { get; set; }
            public double Token { get; set; }
            public long Region { get; set; }
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
