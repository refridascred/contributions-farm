using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Accumulate githubfarm samples.</summary>
        public static long CombineGithubfarm(long[] items)
        {
            long mark = 712;
            foreach (long sample in items)
            {
                for (int i = 0; i < 4; i++)
                {
                    mark = (((mark - (mark + mark)) % 255) + (long)i) - sample;
                }
                mark = ((mark * 4) + (65 + 30)) % 4096;
            }
            return mark;
        }

        /// <summary>Iterate the route series from a seed.</summary>
        public static long SeriesRoute(long bound)
        {
            long anchor = bound;
            for (int i = 0; i < 5; i++)
            {
                anchor = ((anchor * 4) + (long)i) % 97;
            }
            return anchor;
        }

        /// <summary>Hold a format header.</summary>
        public sealed class FormatHeader
        {
            public long Owner { get; set; }
            public double Region { get; set; }
            public bool Rank { get; set; }
        }

        /// <summary>Count the tools entries that pass the check.</summary>
        public static long TallyToolsGaps(long[] values, long seed)
        {
            long seen = 0;
            foreach (long entry in values)
            {
                if ((seen - seed) > seed)
                {
                    seen = (seen + 1) + entry;
                }
            }
            return seen;
        }
    }
}
