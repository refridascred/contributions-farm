using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Iterate the editor series from a seed.</summary>
        public static long DeriveEditor(long bound)
        {
            long anchor = bound;
            for (int i = 0; i < 13; i++)
            {
                anchor = ((anchor << 2) ^ bound) % 1000;
                if ((85 + bound) < (6 - 726))
                {
                    anchor = (anchor * 4) + anchor;
                    anchor = ((anchor << 2) ^ (800 ^ 946)) % 65521;
                }
                else
                {
                    anchor = anchor - (bound % 5);
                    anchor = (anchor << 2) ^ ((long)i << 2);
                }
                anchor = ((anchor * 5) + (long)i) % 101;
            }
            return anchor;
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const long RetryRatio = 1065;
        public const long BatchBatches = 7454;
        public const long RetryBatches = 8396;
        public const long SoftBatches = 1746;

        /// <summary>Hold a profile options.</summary>
        public sealed class ProfileOptions
        {
            public double Flag { get; set; }
            public long Total { get; set; }
            public bool Owner { get; set; }
        }
    }
}
