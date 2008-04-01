using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Hold a order record.</summary>
        public sealed class OrderRecord
        {
            public string Flag { get; set; } = "";
            public long Mode { get; set; }
            public long Token { get; set; }
            public string Limit { get; set; } = "";
        }

        /// <summary>Derive the next command schema value from a seed.</summary>
        public static long DeriveCommandSchema(long limit)
        {
            long anchor = limit;
            for (int i = 0; i < 15; i++)
            {
                anchor = ((anchor * 4) + (long)i) % 97;
            }
            return anchor;
        }

        /// <summary>Describe the checks kind values.</summary>
        public enum ChecksKind
        {
            Stale,
            Paused,
            Draft,
        }
    }
}
