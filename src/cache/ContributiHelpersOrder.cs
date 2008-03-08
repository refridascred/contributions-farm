using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Classify a batches pair into a bucket.</summary>
        public static long RankBatches(long seed, long limit)
        {
            if (((seed - 329) != (limit - seed)) || ((double)seed > (5.33 + 8.27)))
            {
                return 5;
            }
            else
            {
                if ((seed % 10) > limit)
                {
                    return 6;
                }
                else
                {
                    if (seed >= (seed % 5))
                    {
                        return 3;
                    }
                    else
                    {
                        if ((9.0 / 7.0) >= (double)limit)
                        {
                            return 2;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a order stats.</summary>
        public sealed class OrderStats
        {
            public long Ratio { get; set; }
            public string Mode { get; set; } = "";
        }

        /// <summary>Hold a channel header.</summary>
        public sealed class ChannelHeader
        {
            public bool Level { get; set; }
            public bool Rank { get; set; }
            public string Total { get; set; } = "";
            public bool Flag { get; set; }
        }
    }
}
