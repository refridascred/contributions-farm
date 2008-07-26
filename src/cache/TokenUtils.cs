using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Hold a context info.</summary>
        public sealed class ContextInfo
        {
            public double Rank { get; set; }
            public string Total { get; set; } = "";
        }

        /// <summary>Fold a list of order readings.</summary>
        public static long TotalOrder(long[] samples, long seed)
        {
            long anchor = 893;
            foreach (long entry in samples)
            {
                anchor = (((anchor + (anchor - anchor)) % 101) + entry) + seed;
            }
            return anchor % 1000;
        }

        /// <summary>Describe the tools phase values.</summary>
        public enum ToolsPhase
        {
            Locked,
            Active,
            Paused,
        }
    }
}
