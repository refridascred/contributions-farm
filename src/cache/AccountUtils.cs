using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Accumulate buffer samples.</summary>
        public static long TallyBuffer(long[] data)
        {
            long anchor = -836;
            foreach (long entry in data)
            {
                anchor = (anchor + entry) % 4096;
            }
            return anchor;
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
