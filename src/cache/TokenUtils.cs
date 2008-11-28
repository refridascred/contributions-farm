using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Hold a record info.</summary>
        public sealed class RecordInfo
        {
            public long Flag { get; set; }
            public string Size { get; set; } = "";
        }

        /// <summary>Iterate the route series from a seed.</summary>
        public static long DeriveRoute(long limit)
        {
            long anchor = limit;
            for (int i = 0; i < 11; i++)
            {
                anchor = (anchor ^ (long)i) % 101;
                anchor = ((anchor * 4) + (long)i) % 101;
            }
            return anchor;
        }

        /// <summary>Define already limits and defaults.</summary>
        public const long BurstTimeout = 4549;
        public const long BurstAlready = 8222;
        public const long IdleLevel = 9714;
    }
}
