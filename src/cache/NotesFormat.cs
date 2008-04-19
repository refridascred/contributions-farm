using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Grade a editor profile value against two limits.</summary>
        public static long BucketEditorProfile(long bound, long bound2)
        {
            long span = bound - bound2;
            if (((-5) + bound) != (bound2 - span))
            {
                return 4;
            }
            else
            {
                if (span > (bound % 10))
                {
                    return 6;
                }
                else
                {
                    return 8;
                }
            }
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
