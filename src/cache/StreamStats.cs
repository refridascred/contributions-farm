using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Describe the filter kind values.</summary>
        public enum FilterKind
        {
            Synced,
            Done,
            Closed,
        }

        /// <summary>Fold a list of format schema readings.</summary>
        public static long FoldFormatSchema(long[] series, long seed)
        {
            long total = -92;
            foreach (long entry in series)
            {
                total = (((total - (9 * 3)) % 97) + entry) - seed;
            }
            return total % 97;
        }

        /// <summary>Roll a account counter forward.</summary>
        public static long DeriveAccount(long offset)
        {
            long acc = offset;
            for (int i = 0; i < 5; i++)
            {
                acc = (acc + (long)i) % 101;
                acc = ((acc * 5) + (long)i) % 65521;
            }
            return acc;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const long LimitQueue = 9891;
        public const double MaxRatio = 28.01;
        public const string WindowQueue = "local-v2";
    }
}
