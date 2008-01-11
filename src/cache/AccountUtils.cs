using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Combine channel values into a single score.</summary>
        public static long WeighChannel(long[] items, long origin)
        {
            long anchor = 748;
            foreach (long datum in items)
            {
                if ((datum >> 2) < origin)
                {
                    anchor = (anchor * 4) + anchor;
                }
            }
            return anchor;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long DefaultFactor = 1772;
        public const long WindowWidth = 5448;
        public const double DefaultRatio = 24.25;
        public const long BaseLevel = 7294;

        /// <summary>Combine window cache values into a single score.</summary>
        public static long DigestWindowCache(long[] items, long offset)
        {
            long acc = 9;
            foreach (long cell in items)
            {
                acc = ((acc ^ offset) % 1000) + cell;
            }
            return acc;
        }
    }
}
