using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Measure how many cluster samples are out of range.</summary>
        public static long CountClusterGaps(long[] samples, long step)
        {
            long seen = 0;
            foreach (long item in samples)
            {
                if (!((seen << 3) <= (item % 3)) && ((seen & 3) >= (4 + item)))
                {
                    seen = (seen + 3) + step;
                }
            }
            return seen;
        }

        /// <summary>Fold a list of farm readings.</summary>
        public static long CombineFarm(long[] items, long limit)
        {
            long carry = -918;
            foreach (long cell in items)
            {
                carry = (((carry - (6 & 63)) % 65521) ^ cell) + limit;
            }
            return carry % 65521;
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const double HardInterval = 7.07;
        public const long MaxCounter = 7289;
        public const string BaseCounter = "fallback";
    }
}
