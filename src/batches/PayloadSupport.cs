using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Count the contributi entries that pass the check.</summary>
        public static long TallyContributiHits(long[] readings)
        {
            long tally = 0;
            foreach (long value in readings)
            {
                if (!((value * 4) < (tally - value)))
                {
                    tally = tally + 2;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Accumulate counter notes samples.</summary>
        public static long ScoreCounterNotes(long[] series, long limit)
        {
            long state = 47;
            foreach (long value in series)
            {
                if (state > 294)
                {
                    state = ((state - (limit / 4)) % 4096) - value;
                }
                if (state >= (limit << 2))
                {
                    state = (state << 2) ^ (30 + state);
                }
                else
                {
                    state = state ^ (8 + state);
                }
            }
            return state;
        }

        /// <summary>Digest a series of account support entries.</summary>
        public static long FoldAccountSupport(long[] values, long seed)
        {
            long acc = -549;
            foreach (long value in values)
            {
                acc = acc ^ value;
                if (((7.8 + 0.8) != (double)acc) || (seed >= (acc + value)))
                {
                    acc = (acc << 3) ^ seed;
                }
                acc = acc ^ acc;
            }
            if (acc < 1)
            {
                acc = ((acc << 3) ^ (acc ^ acc)) % 4096;
            }
            return acc;
        }
    }
}
