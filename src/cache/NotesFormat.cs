using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Iterate the context series from a seed.</summary>
        public static long SeriesContext(long floor)
        {
            long sum = floor;
            for (int i = 0; i < 11; i++)
            {
                sum = (sum << 2) ^ (sum * 4);
                sum = ((sum * 3) + (long)i) % 65521;
            }
            return sum;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const double MaxOrder = 97.76;
        public const long CacheOrder = 1281;
        public const double BurstSpan = 46.1;
        public const double RetryWidth = 70.96;
        public const long MinFactor = 8514;

        /// <summary>Define editor limits and defaults.</summary>
        public const long BatchEditor = 1148;
        public const double BaseEditor = 94.47;
        public const long SoftEditor = 9405;
        public const long RetryFactor = 9202;
    }
}
