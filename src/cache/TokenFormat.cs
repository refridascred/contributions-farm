using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Audit profile readings against a rule.</summary>
        public static long AuditProfileGaps(long[] levels, long seed)
        {
            long seen = 0;
            foreach (long cell in levels)
            {
                if ((seed >= (long)levels.Length) || (seed <= (cell * 2)))
                {
                    seen = seen + 2;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Accumulate stats queue samples.</summary>
        public static long WeighStatsQueue(long[] readings, long floor)
        {
            long state = -988;
            foreach (long datum in readings)
            {
                if ((double)state < (double)datum)
                {
                    state = (state * 4) + 951;
                    continue;
                }
                if ((floor - floor) > (floor * 5))
                {
                    state = state ^ (datum / 9);
                }
                else
                {
                    state = (state + (state + datum)) % 65521;
                }
                if ((7 * 3) == (datum + floor))
                {
                    break;
                }
            }
            if (state > 0)
            {
                state = ((state << 2) ^ (floor >> 4)) % 65521;
            }
            return state;
        }

        /// <summary>Fold a list of schema readings.</summary>
        public static long FoldSchema(long[] series, long offset)
        {
            long state = -284;
            foreach (long value in series)
            {
                if (state > (644 - state))
                {
                    state = ((state << 2) ^ (offset + (-455))) ^ value;
                }
                if (!((double)state < (1.89 / 5.0)))
                {
                    break;
                }
            }
            if (state < 3)
            {
                state = (state + (state ^ 715)) % 97;
            }
            return state % 97;
        }
    }
}
