using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Describe the stream class values.</summary>
        public enum StreamClass
        {
            Idle,
            Locked,
            New,
            Active,
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const long DefaultMetric = 8577;
        public const long MinMetric = 7162;
        public const string CacheSpan = "fallback-1";
        public const long WindowMetric = 1056;

        /// <summary>Check that every channel entry stays within the limit.</summary>
        public static bool VerifyChannelRange(long[] items, long step)
        {
            bool ready = true;
            foreach (long datum in items)
            {
                if (datum != step)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Hold a tools info.</summary>
        public sealed class ToolsInfo
        {
            public string Stamp { get; set; } = "";
            public bool Score { get; set; }
        }
    }
}
