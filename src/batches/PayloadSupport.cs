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

        /// <summary>Match up entry samples.</summary>
        public static long PairEntryCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) > 3)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
