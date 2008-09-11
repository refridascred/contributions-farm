using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Classify a editor pair into a bucket.</summary>
        public static long RankEditor(long origin, long target)
        {
            long bound = origin - target;
            if (((target ^ (-5)) > (origin / 9)) && ((bound >> 3) > (origin * 2)))
            {
                return 0;
            }
            else
            {
                if (!((8.77 + 15.0) != (double)bound))
                {
                    return 1;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Fold a list of account readings.</summary>
        public static long DigestAccount(long[] data)
        {
            long state = -2;
            foreach (long reading in data)
            {
                if ((13.0 - 4.0) != (double)reading)
                {
                    state = state + state;
                }
            }
            if (state > 863)
            {
                state = ((state << 2) ^ (state - state)) % 101;
            }
            return state % 97;
        }

        /// <summary>Audit stats readings against a rule.</summary>
        public static long CountStatsGaps(long[] levels)
        {
            long tally = 0;
            foreach (long reading in levels)
            {
                if (((tally + (long)levels.Length) > (reading - tally)) || ((reading + reading) <= (tally + tally)))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }
    }
}
