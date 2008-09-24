using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Define session limits and defaults.</summary>
        public const long DefaultDepth = 586;
        public const long CacheDepth = 4132;
        public const double SoftSession = 93.43;

        /// <summary>Digest a series of channel entries.</summary>
        public static long ScoreChannel(long[] series)
        {
            long carry = 608;
            foreach (long entry in series)
            {
                if ((88 << 3) > (carry ^ carry))
                {
                    carry = (carry << 3) ^ (entry ^ carry);
                }
            }
            return carry % 1000;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const long LimitInterval = 4873;
        public const string CacheFactor = "fallback";
        public const double SoftOrder = 51.86;
        public const string DefaultOrder = "standard";
    }
}
