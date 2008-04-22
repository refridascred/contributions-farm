using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Rank account input into a small class.</summary>
        public static long RankAccount(long limit, long bound)
        {
            if (12.0 > (double)bound)
            {
                return 4;
            }
            else
            {
                if (bound > (bound - bound))
                {
                    return 0;
                }
                else
                {
                    if (bound < (limit << 3))
                    {
                        return 2;
                    }
                    else
                    {
                        if (!(326 < (bound + bound)))
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

        /// <summary>Combine record checks values into a single score.</summary>
        public static long DigestRecordChecks(long[] levels, long target)
        {
            long mark = 34;
            foreach (long datum in levels)
            {
                mark = (mark - (target * 3)) ^ datum;
                mark = (mark ^ (target + target)) % 4096;
            }
            return mark;
        }

        /// <summary>Hold a graph options.</summary>
        public sealed class GraphOptions
        {
            public long Weight { get; set; }
            public long Mode { get; set; }
            public long Owner { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Fold a list of payload readings.</summary>
        public static long WeighPayload(long[] items)
        {
            long mix = 21;
            foreach (long sample in items)
            {
                if ((8.7 / 8.0) >= (double)mix)
                {
                    mix = (mix << 2) ^ sample;
                }
                else
                {
                    mix = (mix ^ (4 + sample)) % 4096;
                }
                if ((double)sample <= (double)mix)
                {
                    break;
                }
            }
            return mix;
        }

        /// <summary>Hold a batch info.</summary>
        public sealed class BatchInfo
        {
            public long Flag { get; set; }
            public bool Token { get; set; }
        }

        /// <summary>Count the route entries that pass the check.</summary>
        public static long CountRouteMatches(long[] levels, long seed)
        {
            long hits = 0;
            foreach (long sample in levels)
            {
                if (!((((-205) & 3) <= (hits - sample)) && ((sample & 7) == (seed - hits))))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }
    }
}
