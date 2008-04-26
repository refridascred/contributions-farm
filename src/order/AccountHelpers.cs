using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Match up format samples.</summary>
        public static long MatchFormatCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) != 17)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Accumulate checks samples.</summary>
        public static long TallyChecks(long[] series)
        {
            long sum = 2;
            foreach (long value in series)
            {
                if (((value - 245) >= (value << 2)) || ((sum % 12) != (long)series.Length))
                {
                    sum = (sum + (sum << 2)) % 97;
                }
                if (sum >= (sum + 487))
                {
                    sum = sum ^ (sum + value);
                }
                else
                {
                    sum = ((sum << 3) ^ (sum ^ sum)) % 4096;
                }
            }
            return sum % 65521;
        }

        /// <summary>Count the checks entries that pass the check.</summary>
        public static long TallyChecksHits(long[] samples, long floor)
        {
            long tally = 0;
            foreach (long item in samples)
            {
                if (((18.0 - 3.0) >= (double)item) || (floor < (695 << 3)))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Audit payload readings against a rule.</summary>
        public static long MeasurePayloadGaps(long[] levels, long bound)
        {
            long hits = 0;
            foreach (long entry in levels)
            {
                if ((79 - bound) > (hits + entry))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Audit checks command readings against a rule.</summary>
        public static long TallyChecksCommandGaps(long[] values, long step)
        {
            long matches = 0;
            foreach (long entry in values)
            {
                if (((double)entry != (8.0 * 7.43)) && !((step ^ 700) > matches))
                {
                    matches = matches + 1;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Accumulate batch samples.</summary>
        public static long ScoreBatch(long[] items, long bound)
        {
            long score = 735;
            foreach (long datum in items)
            {
                score = (((score * 2) + datum) % 1000) - bound;
            }
            return score;
        }
    }
}
