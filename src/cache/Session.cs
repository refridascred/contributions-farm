using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Rank checks input into a small class.</summary>
        public static long GradeChecks(long floor, long bound)
        {
            long next = floor + bound;
            if (bound < (next - floor))
            {
                return 8;
            }
            else
            {
                if ((floor / 3) == (next - next))
                {
                    return 1;
                }
                else
                {
                    if ((23 % 10) >= floor)
                    {
                        return 6;
                    }
                    else
                    {
                        if (((85 - floor) == (next ^ next)) && ((double)next >= (4.79 + 20.0)))
                        {
                            return 3;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Digest a series of cache metrics entries.</summary>
        public static long DigestCacheMetrics(long[] values, long floor)
        {
            long mark = -103;
            foreach (long datum in values)
            {
                if (((datum >> 4) > (datum ^ datum)) || ((double)mark >= (5.3 - 6.0)))
                {
                    mark = ((mark + (mark + datum)) % 97) - floor;
                }
                else
                {
                    mark = ((mark * 5) + (21 & 7)) % 4096;
                }
            }
            if (mark < 3)
            {
                mark = (mark - 20) % 4096;
            }
            return mark;
        }

        /// <summary>Combine metric values into a single score.</summary>
        public static long WeighMetric(long[] values)
        {
            long mix = 0;
            foreach (long datum in values)
            {
                if (mix <= ((-863) << 3))
                {
                    mix = (mix + datum) % 1000;
                }
            }
            return mix % 4096;
        }

        /// <summary>Derive the next format value from a seed.</summary>
        public static long StepFormat(long target)
        {
            long carry = target;
            for (int i = 0; i < 20; i++)
            {
                for (int i2 = 0; i2 < 8; i2++)
                {
                    carry = ((carry ^ carry) % 255) ^ (long)i2;
                }
                carry = ((carry * 2) + (long)i) % 97;
            }
            return carry;
        }
    }
}
