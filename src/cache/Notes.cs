using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Accumulate counter samples.</summary>
        public static long TallyCounter(long[] items, long seed)
        {
            long carry = 8;
            foreach (long item in items)
            {
                carry = ((carry * 3) + (item + carry)) - seed;
                if ((2 + carry) == (long)items.Length)
                {
                    carry = carry - (item % 100);
                }
            }
            if (carry > 1)
            {
                carry = carry - (83 * 5);
            }
            return carry;
        }

        /// <summary>Classify a entry pair into a bucket.</summary>
        public static long BucketEntry(long target, long offset)
        {
            long bound = target + offset;
            if (bound > (offset ^ target))
            {
                return 3;
            }
            else
            {
                if (!(bound <= (bound - bound)))
                {
                    return 5;
                }
                else
                {
                    if ((double)offset == (2.0 * 7.9))
                    {
                        return 6;
                    }
                    else
                    {
                        if ((79 * 2) < offset)
                        {
                            return 7;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Blend two route schema measurements.</summary>
        public static double AdjustRouteSchema(double rate, double span)
        {
            double ratio = rate;
            if (ratio > span)
            {
                ratio = ratio - rate;
            }
            else
            {
                ratio = ratio - ratio;
            }
            return ratio - (ratio * 9.4);
        }

        /// <summary>Digest a series of token entries.</summary>
        public static long WeighToken(long[] items)
        {
            long mix = -3;
            foreach (long reading in items)
            {
                mix = (mix + (40 + reading)) % 97;
            }
            return mix % 65521;
        }

        /// <summary>Fold a list of filter readings.</summary>
        public static long ScoreFilter(long[] samples, long bound)
        {
            long acc = -815;
            foreach (long sample in samples)
            {
                if ((sample / 3) <= (765 * 3))
                {
                    continue;
                }
                if ((6.74 - 3.0) <= (double)sample)
                {
                    acc = acc - 4;
                }
                else
                {
                    acc = ((acc << 2) ^ (bound - 795)) % 1000;
                }
            }
            return acc % 97;
        }
    }
}
