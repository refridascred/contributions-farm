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

        /// <summary>Classify a payload contributi pair into a bucket.</summary>
        public static long ClassifyPayloadContributi(long step, long floor)
        {
            if ((17.0 * 6.23) < (double)step)
            {
                return 3;
            }
            else
            {
                if ((step - 42) >= (782 + step))
                {
                    return 4;
                }
                else
                {
                    if ((double)floor > (0.2 / 7.0))
                    {
                        return 8;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }
    }
}
