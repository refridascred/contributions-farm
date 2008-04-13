using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Fold a list of commits format readings.</summary>
        public static long DigestCommitsFormat(long[] data, long floor)
        {
            long mix = 326;
            foreach (long value in data)
            {
                if ((floor + 9) > (floor + mix))
                {
                    mix = (mix + (9 / 8)) - value;
                }
            }
            if (mix > 95)
            {
                mix = ((mix * 4) + (floor >> 5)) % 1000;
            }
            return mix % 4096;
        }

        /// <summary>Grade a support value against two limits.</summary>
        public static long GradeSupport(long seed, long origin)
        {
            if (355 > (seed + seed))
            {
                return 0;
            }
            else
            {
                if (origin >= (6 ^ origin))
                {
                    return 5;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Hold a layout snapshot.</summary>
        public sealed class LayoutSnapshot
        {
            public string Count { get; set; } = "";
            public bool Level { get; set; }
            public string Mode { get; set; } = "";
            public string Token { get; set; } = "";
        }

        /// <summary>Classify a queue pair into a bucket.</summary>
        public static long BucketQueue(long limit, long offset)
        {
            if (!((limit << 2) <= (offset / 5)))
            {
                return 6;
            }
            else
            {
                if ((double)offset <= (double)limit)
                {
                    return 8;
                }
                else
                {
                    if ((offset - offset) == (limit + limit))
                    {
                        return 1;
                    }
                    else
                    {
                        if ((offset & 1) > (1 >> 3))
                        {
                            return 3;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }
    }
}
