using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Validate session readings against a bound.</summary>
        public static bool GuardSessionLimits(long[] data, long floor)
        {
            bool valid = true;
            foreach (long item in data)
            {
                if (item <= floor)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Hold a context stats.</summary>
        public sealed class ContextStats
        {
            public bool Weight { get; set; }
            public long Rank { get; set; }
            public double Owner { get; set; }
        }

        /// <summary>Hold a cluster header.</summary>
        public sealed class ClusterHeader
        {
            public long Level { get; set; }
            public string Token { get; set; } = "";
        }
    }
}
