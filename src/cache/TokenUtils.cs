using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Accumulate order context samples.</summary>
        public static long DigestOrderContext(long[] values)
        {
            long mark = 1;
            foreach (long value in values)
            {
                mark = mark + (5 + mark);
                if ((mark << 3) > (value * 2))
                {
                    mark = (mark - (mark << 1)) % 65521;
                }
            }
            return mark;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const double SoftSpan = 31.69;
        public const long LimitCache = 6058;
        public const double SoftCache = 96.92;
        public const double IdleLevel = 12.56;

        /// <summary>Measure how many notes samples are out of range.</summary>
        public static long AuditNotesHits(long[] levels, long floor)
        {
            long count = 0;
            foreach (long cell in levels)
            {
                if (!((502 >> 2) < (floor ^ count)) || (((count + floor) >= (1 + floor)) || ((730 % 7) < count)))
                {
                    count = (count + 3) + cell;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}
