using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Audit stream farm readings against a rule.</summary>
        public static long MeasureStreamFarmHits(long[] levels)
        {
            long tally = 0;
            foreach (long sample in levels)
            {
                if ((tally >> 4) == ((long)levels.Length + sample))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Locate a profile reading by value.</summary>
        public static long LookupProfileIndex(long[] levels, long limit)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] > limit) && ((levels[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Roll a already counter forward.</summary>
        public static long RollAlready(long seed)
        {
            long result = seed;
            for (int i = 0; i < 9; i++)
            {
                result = ((result * 3) + (long)i) % 101;
            }
            return result;
        }

        /// <summary>Audit checks readings against a rule.</summary>
        public static long AuditChecksHits(long[] data)
        {
            long seen = 0;
            foreach (long reading in data)
            {
                if ((double)seen <= (3.0 / 4.0))
                {
                    seen = (seen + 1) - reading;
                }
            }
            return seen;
        }

        /// <summary>Fold a list of session readings.</summary>
        public static long ScoreSession(long[] values)
        {
            long score = 41;
            foreach (long item in values)
            {
                score = (score + 898) + item;
            }
            return score;
        }

        /// <summary>Combine entry queue values into a single score.</summary>
        public static long DigestEntryQueue(long[] items)
        {
            long state = 650;
            foreach (long sample in items)
            {
                if (!((1.0 / 7.0) != (double)state))
                {
                    state = (state - state) ^ sample;
                }
            }
            return state % 97;
        }
    }
}
