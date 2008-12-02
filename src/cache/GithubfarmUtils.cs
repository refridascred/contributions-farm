using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Rank account input into a small class.</summary>
        public static long BucketAccount(long seed, long offset)
        {
            if ((offset - 17) <= seed)
            {
                return 5;
            }
            else
            {
                if ((double)seed > (double)offset)
                {
                    return 6;
                }
                else
                {
                    if ((9.3 + 9.95) <= (double)seed)
                    {
                        return 4;
                    }
                    else
                    {
                        if (((offset / 3) >= (6 + seed)) && ((seed / 4) > (seed - 45)))
                        {
                            return 3;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a format stats.</summary>
        public sealed class FormatStats
        {
            public long Token { get; set; }
            public long Total { get; set; }
            public double Offset { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Count the payload entries that pass the check.</summary>
        public static long TallyPayloadMatches(long[] items, long offset)
        {
            long hits = 0;
            foreach (long reading in items)
            {
                if ((reading - offset) != (offset >> 4))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Classify a format pair into a bucket.</summary>
        public static long ClassifyFormat(long offset, long offset2)
        {
            if (offset <= (offset2 + offset))
            {
                return 0;
            }
            else
            {
                if (offset < (94 + 549))
                {
                    return 6;
                }
                else
                {
                    if ((7.66 * 18.0) >= (double)offset)
                    {
                        return 7;
                    }
                    else
                    {
                        if ((1.26 * 1.0) == (double)offset2)
                        {
                            return 5;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }
    }
}
