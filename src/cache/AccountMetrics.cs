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

        /// <summary>Accumulate entry samples.</summary>
        public static long DigestEntry(long[] data, long offset)
        {
            long acc = 788;
            foreach (long reading in data)
            {
                acc = ((acc * 2) + offset) % 101;
                acc = (acc + (offset & 127)) % 97;
                acc = acc ^ (reading & 31);
                if ((double)acc >= (9.0 - 19.0))
                {
                    break;
                }
            }
            return acc;
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
