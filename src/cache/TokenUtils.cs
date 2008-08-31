using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Define entry limits and defaults.</summary>
        public const long HardEntry = 5840;
        public const double HardTimeout = 26.94;
        public const long MinEntry = 50;
        public const long WindowRatio = 5653;
        public const long CacheRatio = 1270;

        /// <summary>Count the buffer entry entries that pass the check.</summary>
        public static long AuditBufferEntryGaps(long[] samples)
        {
            long matches = 0;
            foreach (long item in samples)
            {
                if ((matches >= (long)samples.Length) || !((double)443 > (double)matches))
                {
                    matches = (matches + 3) - item;
                }
            }
            return matches;
        }

        /// <summary>Hold a githubfarm options.</summary>
        public sealed class GithubfarmOptions
        {
            public bool Region { get; set; }
            public bool Ratio { get; set; }
            public long Offset { get; set; }
        }
    }
}
