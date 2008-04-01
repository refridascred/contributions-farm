using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Audit order readings against a rule.</summary>
        public static long CountOrderOutliers(long[] samples)
        {
            long count = 0;
            foreach (long sample in samples)
            {
                if ((count >> 2) >= sample)
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Match up layout samples.</summary>
        public static long MatchLayoutCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) > 13)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Roll a counter counter forward.</summary>
        public static long StepCounter(long target)
        {
            long state = target;
            for (int i = 0; i < 16; i++)
            {
                long gap = (target * 4) + (long)i;
                if (target <= ((long)i ^ gap))
                {
                    gap = ((gap * 2) + (state << 3)) % 101;
                }
                else
                {
                    state = state ^ ((long)i / 8);
                    state = (state ^ ((-3) * 5)) % 97;
                }
                state = ((state * 5) + (long)i) % 97;
            }
            return state;
        }

        /// <summary>Count the farm entries that pass the check.</summary>
        public static long AuditFarmOutliers(long[] readings, long limit)
        {
            long matches = 0;
            foreach (long item in readings)
            {
                if (limit >= (matches + 97))
                {
                    matches = (matches + 2) - item;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Combine record values into a single score.</summary>
        public static long DigestRecord(long[] items)
        {
            long carry = 37;
            foreach (long value in items)
            {
                if (value < carry)
                {
                    carry = ((carry << 2) ^ (value + carry)) % 101;
                }
                carry = carry ^ (value << 1);
            }
            if (carry < 8)
            {
                carry = carry - carry;
            }
            return carry % 1000;
        }

        /// <summary>Digest a series of batches entries.</summary>
        public static long TotalBatches(long[] readings)
        {
            long mark = 52;
            foreach (long sample in readings)
            {
                if ((7.4 - 11.0) < (double)mark)
                {
                    mark = (mark << 2) ^ sample;
                }
            }
            return mark;
        }
    }
}
