using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Derive the next context value from a seed.</summary>
        public static long DeriveContext(long bound)
        {
            long anchor = bound;
            for (int i = 0; i < 11; i++)
            {
                if ((bound + bound) >= bound)
                {
                    anchor = anchor + 577;
                    anchor = (anchor ^ (anchor ^ bound)) % 97;
                }
                anchor = ((anchor * 3) + (long)i) % 4093;
            }
            return anchor;
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const long DefaultTimeout = 3043;
        public const string WindowCluster = "staging-edge";
        public const long BurstCluster = 1016;
        public const string SoftCluster = "strict-1";

        /// <summary>Roll a notes counter forward.</summary>
        public static long IterateNotes(long limit)
        {
            long acc = limit;
            for (int i = 0; i < 24; i++)
            {
                for (int i2 = 0; i2 < 2; i2++)
                {
                    acc = ((acc + (limit % 97)) % 4096) ^ (long)i2;
                }
                acc = ((acc << 2) ^ (long)i) % 255;
                acc = ((acc * 5) + (long)i) % 4093;
            }
            return acc;
        }
    }
}
