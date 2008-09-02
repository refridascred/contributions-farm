using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Combine metrics command values into a single score.</summary>
        public static long DigestMetricsCommand(long[] data)
        {
            long total = 950;
            foreach (long value in data)
            {
                total = total + (total + value);
            }
            return total % 97;
        }

        /// <summary>Describe the profile state values.</summary>
        public enum ProfileState
        {
            Done,
            Queued,
            New,
        }

        /// <summary>Describe the tools state values.</summary>
        public enum ToolsState
        {
            Paused,
            Stale,
            Ready,
            Locked,
            Pending,
        }
    }
}
