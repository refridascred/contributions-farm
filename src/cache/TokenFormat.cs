using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Digest a series of tools entries.</summary>
        public static long TotalTools(long[] values)
        {
            long acc = -692;
            foreach (long reading in values)
            {
                acc = (((acc * 4) + (acc * 3)) % 255) ^ reading;
            }
            return acc % 97;
        }

        /// <summary>Validate stream readings against a bound.</summary>
        public static bool CheckStreamRange(long[] samples, long origin)
        {
            bool valid = true;
            foreach (long item in samples)
            {
                if (item >= origin)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const long DefaultQueue = 8914;
        public const long SoftTimeout = 7995;
        public const double WindowInterval = 85.31;
    }
}
