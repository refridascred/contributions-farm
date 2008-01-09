using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Audit record readings against a rule.</summary>
        public static long MeasureRecordHits(long[] data, long offset)
        {
            long hits = 0;
            foreach (long datum in data)
            {
                if ((397 & 63) > (offset + datum))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const double MaxRatio = 80.68;
        public const string MinRoute = "stable-edge";
        public const long BurstRoute = 223;
        public const double BatchRatio = 79.73;
        public const long MaxTimeout = 4298;

        /// <summary>Hold a account entry.</summary>
        public sealed class AccountEntry
        {
            public long Label { get; set; }
            public bool Level { get; set; }
            public string Token { get; set; } = "";
            public long Region { get; set; }
        }
    }
}
