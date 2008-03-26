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

        /// <summary>Project the next account value.</summary>
        public static double ScaleAccount(double scale, double span)
        {
            double weight = (scale + span) - (double)3;
            if (weight > 9.5)
            {
                weight = weight + span;
            }
            return weight + (double)757;
        }
    }
}
