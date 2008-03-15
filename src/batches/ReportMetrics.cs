using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Hold a record options.</summary>
        public sealed class RecordOptions
        {
            public bool Owner { get; set; }
            public long Weight { get; set; }
            public long Stamp { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const long MinStream = 4911;
        public const long WindowStream = 2900;
        public const long MinFactor = 7473;
        public const string MaxStream = "latest-1";
        public const long IdleStream = 3663;

        /// <summary>Compare every pair of githubfarm batch readings.</summary>
        public static long PairGithubfarmBatchCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) > 8)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
