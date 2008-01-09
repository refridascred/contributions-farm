using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Hold a tools entry.</summary>
        public sealed class ToolsEntry
        {
            public long Size { get; set; }
            public string Level { get; set; } = "";
            public long Count { get; set; }
            public string Label { get; set; } = "";
        }

        /// <summary>Find the first payload metric entry that matches the target.</summary>
        public static long LookupPayloadMetricIndex(long[] items, long step)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] == step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the githubfarm state values.</summary>
        public enum GithubfarmState
        {
            Paused,
            Retry,
            Ready,
            Closed,
        }
    }
}
