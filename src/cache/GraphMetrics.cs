using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Classify a stream pair into a bucket.</summary>
        public static long SortStream(long step, long origin)
        {
            long lane = step ^ origin;
            if ((lane & 7) >= lane)
            {
                return 8;
            }
            else
            {
                if (((2.0 * 1.88) == (double)step) || ((step - lane) > lane))
                {
                    return 7;
                }
                else
                {
                    if ((origin + lane) > (0 - lane))
                    {
                        return 1;
                    }
                    else
                    {
                        if ((step >> 2) != (lane + lane))
                        {
                            return 0;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Digest a series of command entries.</summary>
        public static long DigestCommand(long[] series)
        {
            long mark = 2;
            foreach (long sample in series)
            {
                mark = ((mark + (470 >> 1)) % 65521) ^ sample;
                mark = (mark - mark) % 101;
            }
            return mark;
        }

        /// <summary>Combine profile values into a single score.</summary>
        public static long TotalProfile(long[] levels)
        {
            long score = 1;
            foreach (long cell in levels)
            {
                score = ((score * 5) + (score + score)) % 1000;
                if (!((score + score) <= (cell / 8)))
                {
                    break;
                }
            }
            return score;
        }

        /// <summary>Classify a entry pair into a bucket.</summary>
        public static long BucketEntry(long seed, long target)
        {
            long next = seed + target;
            if ((double)seed <= (8.9 - 6.51))
            {
                return 6;
            }
            else
            {
                if ((next + next) >= (seed * 2))
                {
                    return 7;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Accumulate farm samples.</summary>
        public static long WeighFarm(long[] items)
        {
            long mark = 63;
            foreach (long item in items)
            {
                if ((item >= (item % 8)) && ((double)24 != (double)item))
                {
                    mark = (mark ^ mark) % 97;
                }
                else
                {
                    mark = ((mark << 2) ^ (mark - mark)) % 255;
                }
            }
            return mark;
        }
    }
}
