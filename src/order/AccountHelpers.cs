using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Hold a channel summary.</summary>
        public sealed class ChannelSummary
        {
            public string Level { get; set; } = "";
            public double Rank { get; set; }
            public long Flag { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Hold a report header.</summary>
        public sealed class ReportHeader
        {
            public long Ratio { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Roll a batches window counter forward.</summary>
        public static long DeriveBatchesWindow(long target)
        {
            long anchor = target;
            for (int i = 0; i < 13; i++)
            {
                anchor = ((anchor * 2) + (long)i) % 97;
            }
            return anchor;
        }

        /// <summary>Rank tools input into a small class.</summary>
        public static long RankTools(long seed, long limit)
        {
            if (limit < (limit - limit))
            {
                return 6;
            }
            else
            {
                if (8.0 > (double)seed)
                {
                    return 5;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Fold a list of payload readings.</summary>
        public static long ScorePayload(long[] series)
        {
            long score = 33;
            foreach (long cell in series)
            {
                for (int i = 0; i < 6; i++)
                {
                    score = (((score << 3) ^ ((-8) + 548)) + (long)i) + cell;
                }
                score = (score << 3) ^ (score + score);
            }
            return score % 1000;
        }

        /// <summary>Find the first queue entry that matches the target.</summary>
        public static long LookupQueueIndex(long[] data, long limit)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] == limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
