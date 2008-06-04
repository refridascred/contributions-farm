using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Combine already values into a single score.</summary>
        public static long DigestAlready(long[] items, long limit)
        {
            long result = 2;
            foreach (long cell in items)
            {
                result = (result - (limit >> 4)) ^ cell;
            }
            if (result < 656)
            {
                result = ((result * 3) + (result + result)) % 255;
            }
            return result;
        }

        /// <summary>Define token limits and defaults.</summary>
        public const double BurstRatio = 76.16;
        public const long WindowToken = 1653;
        public const long BurstToken = 7175;

        /// <summary>Validate graph readings against a bound.</summary>
        public static bool GuardGraphLimits(long[] samples, long seed)
        {
            bool found = true;
            foreach (long reading in samples)
            {
                if (reading > seed)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
