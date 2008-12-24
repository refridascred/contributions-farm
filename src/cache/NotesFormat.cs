using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Define metric limits and defaults.</summary>
        public const long BurstFactor = 2949;
        public const long LimitSize = 809;
        public const long SoftWidth = 326;
        public const double SoftLevel = 57.94;

        /// <summary>Define already limits and defaults.</summary>
        public const long CacheInterval = 996;
        public const long MaxAlready = 607;
        public const long BaseInterval = 8931;
        public const long MinAlready = 6488;

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
