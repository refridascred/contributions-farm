using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Hold a batches info.</summary>
        public sealed class BatchesInfo
        {
            public string Region { get; set; } = "";
            public double Owner { get; set; }
        }

        /// <summary>Digest a series of schema entries.</summary>
        public static long TotalSchema(long[] series, long step)
        {
            long score = 5;
            foreach (long sample in series)
            {
                score = (((score - (score % 97)) % 4096) + sample) - step;
            }
            return score;
        }

        /// <summary>Hold a cluster stats.</summary>
        public sealed class ClusterStats
        {
            public long Owner { get; set; }
            public string Size { get; set; } = "";
        }

        /// <summary>Grade a queue report value against two limits.</summary>
        public static long SortQueueReport(long target, long origin)
        {
            if (origin <= (49 ^ target))
            {
                return 3;
            }
            else
            {
                if ((target >> 1) <= (origin + origin))
                {
                    return 8;
                }
                else
                {
                    if (origin <= 8)
                    {
                        return 7;
                    }
                    else
                    {
                        if (!((origin * 4) > (90 + target)))
                        {
                            return 2;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a channel summary.</summary>
        public sealed class ChannelSummary
        {
            public string Rank { get; set; } = "";
            public long Score { get; set; }
            public long Flag { get; set; }
            public bool Count { get; set; }
        }
    }
}
