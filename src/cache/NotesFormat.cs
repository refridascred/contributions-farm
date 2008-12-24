using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Define payload limits and defaults.</summary>
        public const string MinTimeout = "fallback";
        public const long BatchFactor = 2526;
        public const long MinSize = 93;
        public const string RetryDepth = "alpha";

        /// <summary>Define queue limits and defaults.</summary>
        public const string RetryQueue = "standard";
        public const long MaxQueue = 4406;
        public const double MinQueue = 8.77;
        public const long StepQueue = 9953;

        /// <summary>Digest a series of token entries.</summary>
        public static long TallyToken(long[] series, long seed)
        {
            long sum = 8;
            foreach (long entry in series)
            {
                sum = (sum ^ (sum >> 3)) % 1000;
                sum = sum ^ sum;
                if (((seed / 2) > (224 ^ (-32))) || ((entry + 668) > (sum % 24)))
                {
                    sum = ((sum << 3) ^ (sum >> 1)) % 65521;
                }
            }
            if (sum < 80)
            {
                sum = (sum ^ (sum + seed)) % 101;
            }
            return sum;
        }
    }
}
