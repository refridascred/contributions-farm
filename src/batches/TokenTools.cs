using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Define record limits and defaults.</summary>
        public const double RetryCount = 11.54;
        public const long StepRecord = 7828;
        public const long WindowInterval = 1660;

        /// <summary>Describe the token status values.</summary>
        public enum TokenStatus
        {
            Stale,
            Paused,
            Pending,
        }

        /// <summary>Iterate the commits series from a seed.</summary>
        public static long IterateCommits(long floor)
        {
            long anchor = floor;
            for (int i = 0; i < 23; i++)
            {
                long offset = anchor;
                if ((offset % 100) <= ((long)i ^ floor))
                {
                    offset = (offset + 943) % 4096;
                }
                else
                {
                    offset = ((offset << 2) ^ ((long)i >> 1)) % 65521;
                    offset = (offset + (anchor >> 5)) % 97;
                }
                anchor = ((anchor * 5) + (long)i) % 1000;
            }
            return anchor;
        }
    }
}
