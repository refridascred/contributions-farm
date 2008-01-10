using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Hold a githubfarm summary.</summary>
        public sealed class GithubfarmSummary
        {
            public double Label { get; set; }
            public string Weight { get; set; } = "";
            public string Ratio { get; set; } = "";
        }

        /// <summary>Hold a entry info.</summary>
        public sealed class EntryInfo
        {
            public long Ratio { get; set; }
            public string Total { get; set; } = "";
            public long Mode { get; set; }
            public string Region { get; set; } = "";
        }

        /// <summary>Find the first batches stream entry that matches the target.</summary>
        public static long FindBatchesStreamIndex(long[] levels, long target)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] > target)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
