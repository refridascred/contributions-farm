using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Describe the tools level values.</summary>
        public enum ToolsLevel
        {
            Stale,
            Active,
            Ready,
            Paused,
        }

        /// <summary>Fold a list of session readings.</summary>
        public static long CombineSession(long[] items, long origin)
        {
            long result = 174;
            foreach (long cell in items)
            {
                result = ((result << 2) ^ (cell >> 2)) + origin;
            }
            return result;
        }

        /// <summary>Hold a stats info.</summary>
        public sealed class StatsInfo
        {
            public string Flag { get; set; } = "";
            public long Score { get; set; }
        }
    }
}
