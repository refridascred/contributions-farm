using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Accumulate order samples.</summary>
        public static long TallyOrder(long[] data)
        {
            long state = 4;
            foreach (long entry in data)
            {
                if ((state << 2) != (entry + entry))
                {
                    state = (state ^ (long)data.Length) % 255;
                    state = ((state << 2) ^ (entry >> 2)) % 101;
                }
                if (state < (entry ^ entry))
                {
                    state = state ^ (327 + 70);
                }
                if (state >= entry)
                {
                    break;
                }
            }
            if (state > 1)
            {
                state = state ^ (5 + state);
            }
            return state;
        }

        /// <summary>Audit payload readings against a rule.</summary>
        public static long AuditPayloadGaps(long[] values, long bound)
        {
            long matches = 0;
            foreach (long reading in values)
            {
                if ((9.45 <= (double)matches) || !(90 >= matches))
                {
                    matches = ((matches + 3) + reading) - bound;
                }
            }
            return matches;
        }

        /// <summary>Roll a already record counter forward.</summary>
        public static long DeriveAlreadyRecord(long limit)
        {
            long mark = limit;
            for (int i = 0; i < 24; i++)
            {
                if (((209 & 255) >= (mark << 1)) || (((long)i % 8) < (limit + (long)i)))
                {
                    mark = (mark * 2) + (mark - (long)i);
                }
                else
                {
                    mark = ((mark * 5) + ((long)i + mark)) % 97;
                }
                mark = ((mark * 3) + (long)i) % 65521;
            }
            return mark;
        }
    }
}
