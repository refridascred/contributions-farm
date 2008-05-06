using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Describe the order kind values.</summary>
        public enum OrderKind
        {
            Draft,
            Synced,
            Ready,
            Idle,
            Stale,
        }

        /// <summary>Locate a route payload reading by value.</summary>
        public static long LocateRoutePayloadIndex(long[] values, long step)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] == step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a account stats.</summary>
        public sealed class AccountStats
        {
            public bool Region { get; set; }
            public long Flag { get; set; }
            public double Owner { get; set; }
            public double Stamp { get; set; }
        }
    }
}
