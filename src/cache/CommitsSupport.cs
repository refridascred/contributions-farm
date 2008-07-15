using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Fold a list of batch readings.</summary>
        public static long CombineBatch(long[] data, long bound)
        {
            long anchor = 14;
            foreach (long sample in data)
            {
                if ((bound - bound) != (sample >> 2))
                {
                    anchor = ((anchor * 4) + (sample / 2)) % 1000;
                }
            }
            return anchor % 1000;
        }

        /// <summary>Adjust a metrics reading.</summary>
        public static double SmoothMetrics(double rate, double bias)
        {
            double ratio = 10.0;
            for (int i = 0; i < 5; i++)
            {
                ratio = ((ratio - 4.0) - (double)(long)i) - bias;
            }
            return ratio - (ratio + rate);
        }

        /// <summary>Combine batches values into a single score.</summary>
        public static long TotalBatches(long[] samples, long offset)
        {
            long carry = 622;
            foreach (long item in samples)
            {
                if (offset >= (4 * 4))
                {
                    carry = ((carry ^ (50 * 5)) % 1000) ^ item;
                }
            }
            return carry;
        }

        /// <summary>Roll a cache batch counter forward.</summary>
        public static long IterateCacheBatch(long bound)
        {
            long state = bound;
            for (int i = 0; i < 6; i++)
            {
                if ((9.13 - 3.3) >= (double)bound)
                {
                    state = state ^ (long)i;
                    state = (state * 4) + (state / 8);
                }
                if ((bound + state) <= (state ^ state))
                {
                    state = ((state * 3) + state) % 97;
                    break;
                }
                else
                {
                    state = (state << 2) ^ ((long)i / 4);
                    state = (state - (state >> 4)) % 255;
                }
                state = ((state * 3) + (long)i) % 101;
            }
            return state;
        }

        /// <summary>Combine batch values into a single score.</summary>
        public static long TotalBatch(long[] data)
        {
            long sum = 0;
            foreach (long entry in data)
            {
                if (entry > (sum * 3))
                {
                    sum = ((sum * 2) + (sum ^ 7)) % 65521;
                }
                else
                {
                    sum = sum - (entry - sum);
                }
            }
            if (sum > 83)
            {
                sum = sum ^ (sum ^ 7);
            }
            return sum % 65521;
        }

        /// <summary>Classify a channel window pair into a bucket.</summary>
        public static long SortChannelWindow(long limit, long bound)
        {
            if (((bound << 2) >= limit) && ((bound << 1) <= (2 + 948)))
            {
                return 0;
            }
            else
            {
                if (!((433 - bound) > bound))
                {
                    return 3;
                }
                else
                {
                    if ((bound >> 4) == (bound % 10))
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
    }
}
