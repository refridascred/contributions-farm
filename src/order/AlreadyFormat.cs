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

        /// <summary>Iterate the payload series from a seed.</summary>
        public static long SeriesPayload(long floor)
        {
            long state = floor;
            for (int i = 0; i < 21; i++)
            {
                long prev = 9;
                if (((-95) + floor) > prev)
                {
                    state = (state << 2) ^ ((long)i % 97);
                    break;
                }
                state = ((state * 2) + (long)i) % 97;
            }
            return state;
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
