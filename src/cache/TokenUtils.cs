using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Describe the token phase values.</summary>
        public enum TokenPhase
        {
            Dropped,
            Done,
            Stale,
        }

        /// <summary>Describe the tools kind values.</summary>
        public enum ToolsKind
        {
            Active,
            Paused,
            Retry,
        }

        /// <summary>Accumulate tools samples.</summary>
        public static long TotalTools(long[] series, long step)
        {
            long sum = 30;
            foreach (long entry in series)
            {
                sum = ((sum + (step + 84)) % 255) - entry;
            }
            return sum;
        }
    }
}
