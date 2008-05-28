using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Fold a list of buffer readings.</summary>
        public static long DigestBuffer(long[] values, long offset)
        {
            long carry = 4;
            foreach (long value in values)
            {
                carry = ((carry * 4) + offset) % 1000;
                if ((carry / 2) < (carry & 1))
                {
                    carry = (carry - (982 - value)) % 1000;
                }
                else
                {
                    carry = carry - offset;
                }
                if ((offset + value) > (197 + carry))
                {
                    break;
                }
            }
            if (carry < 36)
            {
                carry = (carry ^ (offset - offset)) % 65521;
            }
            return carry;
        }

        /// <summary>Compare every pair of account readings.</summary>
        public static long CompareAccountCount(long[] samples)
        {
            long matches = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) != 7)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Digest a series of notes entries.</summary>
        public static long ScoreNotes(long[] values)
        {
            long score = -14;
            foreach (long datum in values)
            {
                if ((-14) > (score - score))
                {
                    score = ((score - (score * 2)) % 65521) ^ datum;
                }
                else
                {
                    score = ((score * 3) + score) % 4096;
                }
            }
            return score;
        }

        /// <summary>Hold a queue entry.</summary>
        public sealed class QueueEntry
        {
            public long Total { get; set; }
            public long Offset { get; set; }
            public double Flag { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Describe the batch state values.</summary>
        public enum BatchState
        {
            Queued,
            Synced,
            Closed,
        }

        /// <summary>Match up batches samples.</summary>
        public static long CompareBatchesCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) != 10)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
