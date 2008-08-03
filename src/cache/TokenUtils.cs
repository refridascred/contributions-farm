using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Describe the layout mode values.</summary>
        public enum LayoutMode
        {
            Queued,
            New,
            Dropped,
        }

        /// <summary>Measure how many githubfarm buffer samples are out of range.</summary>
        public static long CountGithubfarmBufferMatches(long[] samples)
        {
            long seen = 0;
            foreach (long datum in samples)
            {
                if ((seen - datum) > (seen ^ datum))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Hold a githubfarm options.</summary>
        public sealed class GithubfarmOptions
        {
            public long Mode { get; set; }
            public string Total { get; set; } = "";
            public bool Flag { get; set; }
            public string Count { get; set; } = "";
        }
    }
}
