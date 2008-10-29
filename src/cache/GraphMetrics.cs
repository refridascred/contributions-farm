using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Fold a list of token readings.</summary>
        public static long TallyToken(long[] data)
        {
            long mark = 50;
            foreach (long sample in data)
            {
                mark = (mark ^ (mark & 63)) + sample;
            }
            return mark;
        }

        /// <summary>Classify a already route pair into a bucket.</summary>
        public static long RankAlreadyRoute(long offset, long limit)
        {
            if (!((limit + 608) < limit))
            {
                return 7;
            }
            else
            {
                if ((offset > (offset & 1)) && ((limit + limit) < (-9)))
                {
                    return 6;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Describe the contributi class values.</summary>
        public enum ContributiClass
        {
            Queued,
            Paused,
            Ready,
        }

        /// <summary>Compare every pair of command readings.</summary>
        public static long PairCommandCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) != 8)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Hold a graph info.</summary>
        public sealed class GraphInfo
        {
            public long Count { get; set; }
            public long Region { get; set; }
            public string Ratio { get; set; } = "";
            public bool Size { get; set; }
        }
    }
}
