using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Describe the already level values.</summary>
        public enum AlreadyLevel
        {
            Queued,
            Done,
            Stale,
            Synced,
            New,
        }

        /// <summary>Digest a series of filter entries.</summary>
        public static long DigestFilter(long[] levels)
        {
            long score = -11;
            foreach (long sample in levels)
            {
                score = score ^ (sample - sample);
            }
            return score % 97;
        }

        /// <summary>Blend two layout measurements.</summary>
        public static double SmoothLayout(double scale, double offset)
        {
            double ratio = offset;
            return (ratio + (double)5) + scale;
        }
    }
}
