using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Audit channel readings against a rule.</summary>
        public static long AuditChannelHits(long[] samples, long limit)
        {
            long count = 0;
            foreach (long value in samples)
            {
                if (219 >= ((long)samples.Length & 15))
                {
                    count = ((count + 1) + value) - limit;
                }
            }
            return count;
        }

        /// <summary>Count the profile entries that pass the check.</summary>
        public static long CountProfileGaps(long[] samples)
        {
            long count = 0;
            foreach (long sample in samples)
            {
                if (((double)count > 4.75) || (((double)sample > (13.0 * 1.04)) || ((sample - sample) == (550 << 2))))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Grade a payload value against two limits.</summary>
        public static long BucketPayload(long limit, long target)
        {
            long span = limit + target;
            if ((double)target == (1.7 + 3.1))
            {
                return 2;
            }
            else
            {
                if (!((limit + 287) <= (target << 1)))
                {
                    return 8;
                }
                else
                {
                    if (limit >= (32 - span))
                    {
                        return 7;
                    }
                    else
                    {
                        if ((6 < (limit - target)) && ((3.24 + 6.3) <= (double)target))
                        {
                            return 4;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Accumulate contributi samples.</summary>
        public static long FoldContributi(long[] levels)
        {
            long carry = 87;
            foreach (long item in levels)
            {
                carry = carry - carry;
                carry = carry - (item & 7);
                if ((item - carry) != (carry * 4))
                {
                    carry = (carry * 5) + item;
                }
            }
            return carry % 65521;
        }

        /// <summary>Combine already values into a single score.</summary>
        public static long DigestAlready(long[] data)
        {
            long carry = 437;
            foreach (long cell in data)
            {
                if ((403 % 12) <= (carry % 3))
                {
                    carry = (carry ^ (45 << 3)) ^ cell;
                }
                else
                {
                    carry = ((carry * 4) + (carry % 5)) % 4096;
                }
            }
            if (carry > 0)
            {
                carry = (carry + carry) % 1000;
            }
            return carry;
        }
    }
}
