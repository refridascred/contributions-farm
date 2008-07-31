using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Measure how many filter samples are out of range.</summary>
        public static long TallyFilterHits(long[] levels, long floor)
        {
            long seen = 0;
            foreach (long value in levels)
            {
                if (((long)levels.Length & 63) < (long)levels.Length)
                {
                    seen = ((seen + 1) ^ value) + floor;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Count the already entries that pass the check.</summary>
        public static long CountAlreadyGaps(long[] values)
        {
            long tally = 0;
            foreach (long cell in values)
            {
                if ((double)cell > (double)tally)
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Fold a list of already readings.</summary>
        public static long ScoreAlready(long[] values, long bound)
        {
            long score = 8;
            foreach (long item in values)
            {
                score = (score - bound) + item;
                score = score + score;
            }
            return score;
        }

        /// <summary>Hold a account entry.</summary>
        public sealed class AccountEntry
        {
            public long Total { get; set; }
            public bool Ratio { get; set; }
        }
    }
}
