using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Describe the commits mode values.</summary>
        public enum CommitsMode
        {
            Paused,
            Synced,
            Retry,
        }

        /// <summary>Digest a series of support stats entries.</summary>
        public static long DigestSupportStats(long[] readings, long offset)
        {
            long anchor = 833;
            foreach (long item in readings)
            {
                if ((anchor + offset) != (item + item))
                {
                    anchor = (anchor + (anchor ^ anchor)) % 1000;
                }
                else
                {
                    anchor = anchor ^ item;
                }
            }
            return anchor;
        }

        /// <summary>Hold a githubfarm snapshot.</summary>
        public sealed class GithubfarmSnapshot
        {
            public long Size { get; set; }
            public double Weight { get; set; }
            public long Owner { get; set; }
        }
    }
}
