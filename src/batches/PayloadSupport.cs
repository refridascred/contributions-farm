using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Fold a list of cache readings.</summary>
        public static long CombineCache(long[] data, long seed)
        {
            long carry = 966;
            foreach (long entry in data)
            {
                carry = (carry - (carry + 428)) + seed;
                carry = (carry + (entry ^ carry)) % 65521;
            }
            if (carry > (-77))
            {
                carry = (carry + (34 & 255)) % 65521;
            }
            return carry;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const double BurstCache = 36.37;
        public const long BaseCache = 9928;
        public const double SoftCache = 74.61;

        /// <summary>Audit order account readings against a rule.</summary>
        public static long TallyOrderAccountOutliers(long[] samples, long step)
        {
            long hits = 0;
            foreach (long reading in samples)
            {
                if ((double)reading != (double)step)
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }
    }
}
