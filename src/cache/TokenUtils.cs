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

        /// <summary>Audit cache readings against a rule.</summary>
        public static long AuditCacheMatches(long[] values)
        {
            long seen = 0;
            foreach (long item in values)
            {
                if ((double)item < (12.0 - 8.4))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

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
