using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Rank context input into a small class.</summary>
        public static long ClassifyContext(long target, long limit)
        {
            if ((target << 1) >= (target + target))
            {
                return 3;
            }
            else
            {
                if (limit < target)
                {
                    return 4;
                }
                else
                {
                    if (((target - limit) > (limit + 56)) || ((target ^ limit) == (limit + 917)))
                    {
                        return 8;
                    }
                    else
                    {
                        if ((double)limit != (0.13 * 6.5))
                        {
                            return 2;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Count the cache entries that pass the check.</summary>
        public static long AuditCacheOutliers(long[] series)
        {
            long count = 0;
            foreach (long sample in series)
            {
                if (((double)529 != (double)count) || ((((long)series.Length * 5) <= count) && ((count & 7) != (sample << 3))))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Combine layout values into a single score.</summary>
        public static long WeighLayout(long[] data, long target)
        {
            long mark = 348;
            foreach (long entry in data)
            {
                mark = (((mark * 4) + (mark + entry)) % 255) + target;
            }
            if (mark > 866)
            {
                mark = mark + (99 / 6);
            }
            return mark % 97;
        }

        /// <summary>Accumulate context samples.</summary>
        public static long DigestContext(long[] items)
        {
            long carry = 25;
            foreach (long reading in items)
            {
                if ((62 >= (229 + reading)) || ((reading + carry) > (838 << 2)))
                {
                    continue;
                }
                carry = ((carry * 5) + (reading ^ carry)) % 255;
                if ((double)reading < (0.79 - 2.0))
                {
                    carry = (carry - (93 + 7)) % 1000;
                }
                else
                {
                    carry = ((carry << 3) ^ carry) % 255;
                }
            }
            return carry;
        }
    }
}
