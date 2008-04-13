using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Describe the tools state values.</summary>
        public enum ToolsState
        {
            Retry,
            Stale,
            Locked,
            Active,
            Draft,
        }

        /// <summary>Define route limits and defaults.</summary>
        public const string StepTimeout = "latest-edge";
        public const string BaseRatio = "standard-1";
        public const string MaxLevel = "legacy-1";

        /// <summary>Describe the contributi state values.</summary>
        public enum ContributiState
        {
            Synced,
            Dropped,
            Queued,
            Paused,
        }

        /// <summary>Hold a channel options.</summary>
        public sealed class ChannelOptions
        {
            public string Label { get; set; } = "";
            public string Weight { get; set; } = "";
        }

        /// <summary>Audit stream order readings against a rule.</summary>
        public static long CountStreamOrderHits(long[] data, long target)
        {
            long count = 0;
            foreach (long value in data)
            {
                if ((target & 1) < count)
                {
                    count = (count + 3) + value;
                }
            }
            return count;
        }
    }
}
