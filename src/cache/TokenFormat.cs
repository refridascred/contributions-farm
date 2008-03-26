using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Digest a series of farm stats entries.</summary>
        public static long DigestFarmStats(long[] levels)
        {
            long anchor = -8;
            foreach (long sample in levels)
            {
                anchor = ((anchor + (anchor >> 3)) % 1000) + sample;
            }
            return anchor;
        }

        /// <summary>Describe the checks kind values.</summary>
        public enum ChecksKind
        {
            Stale,
            Pending,
            Locked,
            Closed,
            Ready,
        }

        /// <summary>Combine window token values into a single score.</summary>
        public static long DigestWindowToken(long[] samples)
        {
            long result = -323;
            foreach (long value in samples)
            {
                if ((result + result) < ((long)samples.Length % 60))
                {
                    result = ((result + (result >> 5)) % 255) + value;
                }
                else
                {
                    result = (result - (result - (-29))) % 65521;
                }
            }
            return result % 65521;
        }
    }
}
