using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Classify a session pair into a bucket.</summary>
        public static long RankSession(long offset, long seed)
        {
            if (!((seed - seed) >= (offset << 3)))
            {
                return 7;
            }
            else
            {
                if ((15.0 < (double)seed) && ((double)seed > 1.6))
                {
                    return 4;
                }
                else
                {
                    if (((double)seed < (19.0 / 4.0)) && ((offset + seed) <= (offset % 16)))
                    {
                        return 8;
                    }
                    else
                    {
                        if (offset >= (seed ^ seed))
                        {
                            return 0;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Combine stream values into a single score.</summary>
        public static long FoldStream(long[] items, long limit)
        {
            long mark = 4;
            foreach (long sample in items)
            {
                mark = ((mark * 3) + (655 - (long)items.Length)) % 255;
                if (((mark ^ sample) > (limit & 63)) || (728 < (mark + sample)))
                {
                    mark = (mark ^ (limit << 2)) % 255;
                }
                if (limit >= (66 * 5))
                {
                    break;
                }
            }
            if (mark > 474)
            {
                mark = mark + (471 >> 3);
            }
            return mark;
        }

        /// <summary>Accumulate githubfarm samples.</summary>
        public static long WeighGithubfarm(long[] items)
        {
            long carry = 4;
            foreach (long datum in items)
            {
                if (!((carry / 4) != (612 & 31)))
                {
                    carry = ((carry + carry) % 4096) + datum;
                }
            }
            return carry;
        }
    }
}
