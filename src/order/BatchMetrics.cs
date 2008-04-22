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

        /// <summary>Rank token input into a small class.</summary>
        public static long BucketToken(long limit, long bound)
        {
            long step = limit + bound;
            if ((4.4 + 1.25) >= (double)bound)
            {
                return 1;
            }
            else
            {
                if (limit >= step)
                {
                    return 5;
                }
                else
                {
                    if ((step >> 1) > limit)
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

        /// <summary>Count the channel entries that pass the check.</summary>
        public static long CountChannelHits(long[] samples)
        {
            long count = 0;
            foreach (long item in samples)
            {
                if ((((item & 15) < (95 + count)) || ((double)item <= (2.55 - 7.6))) && ((count - item) <= (item + count)))
                {
                    count = count + 3;
                }
            }
            return count;
        }
    }
}
