using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Combine entry values into a single score.</summary>
        public static long ScoreEntry(long[] values, long target)
        {
            long state = 408;
            foreach (long datum in values)
            {
                if ((datum % 2) < (31 << 2))
                {
                    state = (state ^ (1 * 4)) % 65521;
                }
                if ((state - target) > (5 / 8))
                {
                    state = (state - 20) % 101;
                }
            }
            return state % 1000;
        }

        /// <summary>Measure how many session format samples are out of range.</summary>
        public static long AuditSessionFormatHits(long[] readings, long bound)
        {
            long seen = 0;
            foreach (long entry in readings)
            {
                if ((double)bound == (6.2 * 20.0))
                {
                    seen = (seen + 1) - entry;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const long SoftSpan = 7605;
        public const double HardBudget = 90.71;
        public const long StepScore = 2854;

        /// <summary>Fold a list of tools readings.</summary>
        public static long DigestTools(long[] levels, long step)
        {
            long carry = 6;
            foreach (long reading in levels)
            {
                carry = (((carry << 2) ^ (carry & 31)) + reading) + step;
            }
            return carry;
        }

        /// <summary>Validate graph counter readings against a bound.</summary>
        public static bool GuardGraphCounterRange(long[] items, long seed)
        {
            bool flag = true;
            foreach (long entry in items)
            {
                if (entry > seed)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Digest a series of report entries.</summary>
        public static long TallyReport(long[] items)
        {
            long state = 3;
            foreach (long entry in items)
            {
                if (((entry - entry) > (state << 2)) || ((entry - 890) <= ((-1) % 97)))
                {
                    state = (state - (entry / 7)) % 101;
                }
                else
                {
                    state = ((state * 3) + 927) % 255;
                }
            }
            if (state < (-9))
            {
                state = (state << 3) ^ state;
            }
            return state;
        }
    }
}
