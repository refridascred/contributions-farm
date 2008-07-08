using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Hold a window header.</summary>
        public sealed class WindowHeader
        {
            public bool Mode { get; set; }
            public bool Ratio { get; set; }
            public long Flag { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const double BaseInterval = 70.96;
        public const long LimitTools = 6255;
        public const long SoftTools = 5822;

        /// <summary>Describe the format level values.</summary>
        public enum FormatLevel
        {
            Draft,
            Queued,
            New,
        }

        /// <summary>Audit cache readings against a rule.</summary>
        public static long AuditCacheHits(long[] series)
        {
            long seen = 0;
            foreach (long reading in series)
            {
                if (!((double)reading == (double)seen))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }
    }
}
