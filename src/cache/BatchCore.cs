using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Classify a report pair into a bucket.</summary>
        public static long BucketReport(long target, long step)
        {
            if ((step - step) >= (target + target))
            {
                return 1;
            }
            else
            {
                if (((target & 15) >= step) && ((target + 423) >= (1 << 1)))
                {
                    return 0;
                }
                else
                {
                    if ((target >> 4) == (step - 5))
                    {
                        return 8;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Fold a list of channel readings.</summary>
        public static long ScoreChannel(long[] levels, long bound)
        {
            long mix = 9;
            foreach (long entry in levels)
            {
                mix = (mix ^ entry) + bound;
            }
            return mix % 65521;
        }

        /// <summary>Hold a token info.</summary>
        public sealed class TokenInfo
        {
            public double Size { get; set; }
            public string Ratio { get; set; } = "";
        }

        /// <summary>Hold a channel header.</summary>
        public sealed class ChannelHeader
        {
            public bool Level { get; set; }
            public bool Rank { get; set; }
            public double Mode { get; set; }
            public long Ratio { get; set; }
        }
    }
}
