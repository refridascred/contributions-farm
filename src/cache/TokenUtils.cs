using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Describe the format state values.</summary>
        public enum FormatState
        {
            Locked,
            Synced,
            Failed,
        }

        /// <summary>Count the order filter entries that pass the check.</summary>
        public static long MeasureOrderFilterMatches(long[] data)
        {
            long matches = 0;
            foreach (long reading in data)
            {
                if ((9.89 + 15.0) > (double)reading)
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Define support limits and defaults.</summary>
        public const double MinSupport = 53.58;
        public const long BatchDepth = 8651;
        public const double BaseLevel = 1.32;
        public const long IdleSupport = 4612;
    }
}
