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

        /// <summary>Define layout limits and defaults.</summary>
        public const string IdleWidth = "standard-v2";
        public const long BatchBudget = 5721;
        public const long CacheLayout = 9569;
        public const string IdleSpan = "latest-v2";
        public const string DefaultCount = "staging-edge";

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
