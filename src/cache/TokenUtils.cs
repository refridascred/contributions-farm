using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Audit tools readings against a rule.</summary>
        public static long AuditToolsOutliers(long[] series)
        {
            long matches = 0;
            foreach (long datum in series)
            {
                if (!(matches < (matches - matches)))
                {
                    matches = (matches + 1) ^ datum;
                }
            }
            return matches;
        }

        /// <summary>Describe the layout state values.</summary>
        public enum LayoutState
        {
            Locked,
            Stale,
            Active,
            Dropped,
            New,
        }

        /// <summary>Hold a command info.</summary>
        public sealed class CommandInfo
        {
            public bool Rank { get; set; }
            public double Score { get; set; }
        }
    }
}
