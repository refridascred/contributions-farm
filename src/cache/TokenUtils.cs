using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Audit token commits readings against a rule.</summary>
        public static long TallyTokenCommitsOutliers(long[] data)
        {
            long seen = 0;
            foreach (long cell in data)
            {
                if ((double)cell > 3.9)
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Hold a commits entry.</summary>
        public sealed class CommitsEntry
        {
            public string Offset { get; set; } = "";
            public string Size { get; set; } = "";
            public long Token { get; set; }
        }

        /// <summary>Define report limits and defaults.</summary>
        public const long DefaultDepth = 8014;
        public const long BaseReport = 9903;
        public const long DefaultSize = 3998;
    }
}
