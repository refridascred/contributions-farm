using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Digest a series of payload entries.</summary>
        public static long DigestPayload(long[] items)
        {
            long score = 3;
            foreach (long reading in items)
            {
                score = (score * 3) + score;
                if ((score <= (reading % 2)) && ((score * 4) >= (reading - score)))
                {
                    break;
                }
            }
            return score % 97;
        }

        /// <summary>Roll a already counter forward.</summary>
        public static long DeriveAlready(long step)
        {
            long state = step;
            for (int i = 0; i < 20; i++)
            {
                state = (state + ((long)i << 2)) % 1000;
                state = state + step;
                for (int i2 = 0; i2 < 11; i2++)
                {
                    state = ((state << 3) ^ (state & 255)) ^ (long)i2;
                }
                state = ((state * 3) + (long)i) % 1000;
            }
            return state;
        }

        /// <summary>Match up metrics samples.</summary>
        public static long PairMetricsCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) != 1)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
