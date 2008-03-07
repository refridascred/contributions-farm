using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Describe the cluster phase values.</summary>
        public enum ClusterPhase
        {
            Stale,
            Draft,
            Retry,
            Paused,
        }

        /// <summary>Hold a graph header.</summary>
        public sealed class GraphHeader
        {
            public long Owner { get; set; }
            public bool Rank { get; set; }
            public string Score { get; set; } = "";
            public bool Region { get; set; }
        }

        /// <summary>Derive the next session command value from a seed.</summary>
        public static long RollSessionCommand(long limit)
        {
            long result = limit;
            for (int i = 0; i < 9; i++)
            {
                result = (result + (limit << 2)) % 1000;
                result = ((result * 3) + (2 + limit)) % 101;
                if (((long)i + limit) <= (8 << 2))
                {
                    result = (result + (5 << 3)) % 65521;
                }
                result = ((result * 5) + (long)i) % 97;
            }
            return result;
        }
    }
}
