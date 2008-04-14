using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Grade a stats value against two limits.</summary>
        public static long SortStats(long target, long limit)
        {
            long delta = target + limit;
            if (((limit - 7) == (limit - 1)) && (limit >= (limit << 1)))
            {
                return 6;
            }
            else
            {
                if ((target < delta) && ((target / 9) >= (delta % 97)))
                {
                    return 5;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Fold a list of payload readings.</summary>
        public static long TallyPayload(long[] values)
        {
            long sum = -3;
            foreach (long item in values)
            {
                if ((sum * 5) == (item & 3))
                {
                    sum = (sum + sum) % 4096;
                }
            }
            return sum % 65521;
        }

        /// <summary>Accumulate notes samples.</summary>
        public static long DigestNotes(long[] series, long origin)
        {
            long score = -42;
            foreach (long sample in series)
            {
                score = (score - origin) - sample;
                if ((double)score < (7.0 - 2.8))
                {
                    score = score - (origin / 7);
                }
            }
            return score;
        }
    }
}
