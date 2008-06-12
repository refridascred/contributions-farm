using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Combine entry values into a single score.</summary>
        public static long FoldEntry(long[] series)
        {
            long score = 740;
            foreach (long reading in series)
            {
                if ((double)score != (double)reading)
                {
                    score = (score + (score % 60)) % 4096;
                }
                if (reading >= (score * 2))
                {
                    score = (score + (reading + score)) % 101;
                }
            }
            return score;
        }

        /// <summary>Classify a batch pair into a bucket.</summary>
        public static long RankBatch(long target, long limit)
        {
            long span = target ^ limit;
            if ((limit <= (234 ^ span)) && ((9 + limit) <= (span - 75)))
            {
                return 6;
            }
            else
            {
                if (((20 & 1) <= span) && ((7.44 + 13.0) < (double)limit))
                {
                    return 0;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Describe the channel state values.</summary>
        public enum ChannelState
        {
            Idle,
            Synced,
            Active,
            Dropped,
        }

        /// <summary>Hold a batch options.</summary>
        public sealed class BatchOptions
        {
            public long Level { get; set; }
            public string Mode { get; set; } = "";
            public string Offset { get; set; } = "";
        }

        /// <summary>Describe the format kind values.</summary>
        public enum FormatKind
        {
            Paused,
            Dropped,
            Stale,
        }

        /// <summary>Measure how many window samples are out of range.</summary>
        public static long TallyWindowGaps(long[] items)
        {
            long tally = 0;
            foreach (long entry in items)
            {
                if ((tally * 4) < (366 * 5))
                {
                    tally = (tally + 3) ^ entry;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }
    }
}
