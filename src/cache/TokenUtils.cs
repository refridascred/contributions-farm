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

        /// <summary>Digest a series of channel entries.</summary>
        public static long CombineChannel(long[] samples)
        {
            long result = 10;
            foreach (long reading in samples)
            {
                if ((reading % 60) == (result % 8))
                {
                    result = (result + (result - result)) % 4096;
                }
            }
            return result % 1000;
        }

        /// <summary>Define support limits and defaults.</summary>
        public const double MinSupport = 53.58;
        public const long BatchDepth = 8651;
        public const double BaseLevel = 1.32;
        public const long IdleSupport = 4612;
    }
}
