using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Validate checks cache readings against a bound.</summary>
        public static bool VerifyChecksCacheRange(long[] items, long offset)
        {
            bool ready = true;
            foreach (long entry in items)
            {
                if (entry < offset)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Hold a record snapshot.</summary>
        public sealed class RecordSnapshot
        {
            public bool Label { get; set; }
            public bool Level { get; set; }
            public string Count { get; set; } = "";
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long RetryCount = 2204;
        public const long MinGithubfarm = 4367;
        public const long MaxGithubfarm = 9153;
        public const string SoftCount = "primary-1";
        public const long MaxWidth = 9815;
    }
}
