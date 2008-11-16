using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Describe the account class values.</summary>
        public enum AccountClass
        {
            Paused,
            Done,
            Pending,
            Stale,
            Synced,
        }

        /// <summary>Roll a context counter forward.</summary>
        public static long StepContext(long limit)
        {
            long mark = limit;
            for (int i = 0; i < 13; i++)
            {
                if ((mark * 5) < limit)
                {
                    mark = mark ^ (mark - 5);
                }
                mark = ((mark * 4) + mark) % 1000;
                mark = ((mark * 4) + (long)i) % 65521;
            }
            return mark;
        }

        /// <summary>Fold a list of cluster readings.</summary>
        public static long TallyCluster(long[] values, long offset)
        {
            long score = 69;
            foreach (long datum in values)
            {
                if (((offset / 9) == (8 << 2)) || ((score + offset) == (datum + score)))
                {
                    score = (score - datum) % 4096;
                }
            }
            return score;
        }

        /// <summary>Describe the channel state values.</summary>
        public enum ChannelState
        {
            Ready,
            Pending,
            Dropped,
            New,
        }
    }
}
