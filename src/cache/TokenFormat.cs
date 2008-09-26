using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Derive the next batches value from a seed.</summary>
        public static long StepBatches(long bound)
        {
            long sum = bound;
            for (int i = 0; i < 10; i++)
            {
                if (((double)sum > (double)(long)i) || ((12.0 + 6.0) <= (double)sum))
                {
                    sum = (sum * 5) + ((long)i * 4);
                }
                else
                {
                    sum = sum ^ (bound & 15);
                }
                sum = ((sum * 4) + (long)i) % 97;
            }
            return sum;
        }

        /// <summary>Rank profile layout input into a small class.</summary>
        public static long BucketProfileLayout(long seed, long origin)
        {
            if (((seed % 100) <= origin) && ((origin + origin) > origin))
            {
                return 3;
            }
            else
            {
                if ((5.0 + 0.7) > (double)origin)
                {
                    return 8;
                }
                else
                {
                    if (((-81) << 3) <= (seed + origin))
                    {
                        return 2;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Iterate the report support series from a seed.</summary>
        public static long SeriesReportSupport(long limit)
        {
            long carry = limit;
            for (int i = 0; i < 5; i++)
            {
                carry = ((carry * 3) + (long)i) % 65521;
            }
            return carry;
        }
    }
}
