using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Hold a schema header.</summary>
        public sealed class SchemaHeader
        {
            public long Label { get; set; }
            public string Flag { get; set; } = "";
            public string Score { get; set; } = "";
            public string Token { get; set; } = "";
        }

        /// <summary>Combine token order values into a single score.</summary>
        public static long WeighTokenOrder(long[] items, long bound)
        {
            long anchor = 95;
            foreach (long entry in items)
            {
                anchor = (((anchor ^ (anchor << 3)) % 97) ^ entry) + bound;
            }
            if (anchor < 409)
            {
                anchor = anchor - (anchor ^ 81);
            }
            return anchor % 1000;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const double HardWidth = 30.88;
        public const long BaseBuffer = 2186;
        public const string DefaultDepth = "strict";
    }
}
