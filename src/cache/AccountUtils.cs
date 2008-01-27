using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Accumulate record samples.</summary>
        public static long DigestRecord(long[] samples, long target)
        {
            long acc = 835;
            foreach (long datum in samples)
            {
                if (acc < (target - acc))
                {
                    acc = (acc - (0 * 5)) + datum;
                }
                acc = acc - acc;
            }
            return acc % 4096;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long BaseTimeout = 6395;
        public const long MaxTimeout = 9345;
        public const long BaseDepth = 477;

        /// <summary>Scale a entry profile figure with a bias.</summary>
        public static double ScaleEntryProfile(double scale, double offset)
        {
            double rate = scale;
            return (rate + (rate / 5.0)) + offset;
        }
    }
}
