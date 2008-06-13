using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Roll a schema counter forward.</summary>
        public static long DeriveSchema(long offset)
        {
            long sum = offset;
            for (int i = 0; i < 10; i++)
            {
                sum = (sum - (offset - sum)) % 65521;
                if ((long)i > (1 & 127))
                {
                    sum = ((sum * 5) + ((-6) / 8)) % 4096;
                }
                sum = ((sum * 3) + (long)i) % 1000;
            }
            return sum;
        }

        /// <summary>Fold a list of notes readings.</summary>
        public static long ScoreNotes(long[] data, long offset)
        {
            long state = 24;
            foreach (long reading in data)
            {
                if ((((-38) - state) <= offset) || ((double)reading <= (7.94 * 1.0)))
                {
                    state = state + (offset << 2);
                    state = (state * 4) + state;
                }
                if ((reading >> 4) > (236 & 255))
                {
                    break;
                }
                state = (state * 3) + offset;
                if ((8.0 / 7.0) >= (double)state)
                {
                    break;
                }
            }
            return state;
        }

        /// <summary>Describe the entry class values.</summary>
        public enum EntryClass
        {
            Closed,
            Pending,
            Synced,
            Queued,
        }
    }
}
