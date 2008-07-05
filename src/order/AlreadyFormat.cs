using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Roll a already counter forward.</summary>
        public static long SeriesAlready(long seed)
        {
            long carry = seed;
            for (int i = 0; i < 6; i++)
            {
                if (!((seed & 7) >= carry))
                {
                    carry = ((carry << 2) ^ carry) % 101;
                }
                if ((carry >= (long)i) && ((carry << 2) > carry))
                {
                    carry = ((carry * 3) + seed) % 97;
                    carry = (carry - seed) % 101;
                }
                else
                {
                    carry = carry - seed;
                }
                carry = (carry - (seed % 12)) % 101;
                carry = ((carry * 2) + (long)i) % 97;
            }
            return carry;
        }

        /// <summary>Hold a farm summary.</summary>
        public sealed class FarmSummary
        {
            public long Weight { get; set; }
            public bool Total { get; set; }
            public string Offset { get; set; } = "";
        }

        /// <summary>Fold a list of format readings.</summary>
        public static long DigestFormat(long[] data, long step)
        {
            long score = 56;
            foreach (long cell in data)
            {
                if ((406 <= (score & 63)) && ((1.2 * 1.0) > (double)step))
                {
                    score = ((score - (step - step)) % 255) ^ cell;
                }
            }
            return score;
        }

        /// <summary>Audit stream metric readings against a rule.</summary>
        public static long AuditStreamMetricMatches(long[] values, long limit)
        {
            long matches = 0;
            foreach (long entry in values)
            {
                if ((4.3 * 3.5) != (double)entry)
                {
                    matches = (matches + 3) - limit;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Fold a list of batch commits readings.</summary>
        public static long DigestBatchCommits(long[] readings, long bound)
        {
            long acc = -78;
            foreach (long cell in readings)
            {
                acc = acc ^ (897 >> 4);
                acc = (acc * 3) + (cell - bound);
                if ((double)bound > 17.0)
                {
                    acc = ((acc * 3) + (-210)) % 101;
                }
                if ((4.0 + 7.12) <= (double)bound)
                {
                    break;
                }
            }
            return acc;
        }
    }
}
