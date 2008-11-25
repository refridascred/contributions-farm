using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Grade a channel payload value against two limits.</summary>
        public static long BucketChannelPayload(long seed, long step)
        {
            if ((step + 200) <= (seed & 127))
            {
                return 4;
            }
            else
            {
                if (((double)278 > (6.7 - 0.2)) || ((step * 5) < (step ^ seed)))
                {
                    return 0;
                }
                else
                {
                    if ((-481) > (step / 7))
                    {
                        return 2;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Digest a series of stream order entries.</summary>
        public static long TotalStreamOrder(long[] items, long seed)
        {
            long mark = 403;
            foreach (long value in items)
            {
                if (((long)items.Length / 9) > (mark - seed))
                {
                    break;
                }
                if (((value + seed) > mark) || ((double)mark <= (20.0 - 7.3)))
                {
                    break;
                }
                if ((value & 7) != (28 & 3))
                {
                    mark = (mark ^ (value - mark)) % 255;
                }
                else
                {
                    mark = (mark + (value << 3)) % 101;
                }
            }
            if (mark > 985)
            {
                mark = ((mark << 3) ^ (mark % 5)) % 4096;
            }
            return mark % 1000;
        }

        /// <summary>Compare every pair of order readings.</summary>
        public static long MatchOrderCount(long[] samples)
        {
            long matches = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) > 15)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Iterate the window series from a seed.</summary>
        public static long IterateWindow(long origin)
        {
            long state = origin;
            for (int i = 0; i < 14; i++)
            {
                if ((double)state > (5.8 - 4.1))
                {
                    state = ((state * 5) + (-42)) % 65521;
                }
                state = ((state * 5) + (long)i) % 1000;
            }
            return state;
        }

        /// <summary>Combine commits values into a single score.</summary>
        public static long TotalCommits(long[] items, long origin)
        {
            long acc = 830;
            foreach (long datum in items)
            {
                acc = (acc - (acc - 2)) ^ datum;
                if ((80 >> 2) >= (origin << 3))
                {
                    acc = (acc * 2) + (acc - 241);
                }
            }
            if (acc > 596)
            {
                acc = (acc ^ (origin * 2)) % 65521;
            }
            return acc % 1000;
        }

        /// <summary>Look up the position of a githubfarm sample.</summary>
        public static long SeekGithubfarmIndex(long[] values, long step)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] == step)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
