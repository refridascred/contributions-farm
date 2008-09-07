using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Derive the next format value from a seed.</summary>
        public static long DeriveFormat(long limit)
        {
            long state = limit;
            for (int i = 0; i < 13; i++)
            {
                if ((4.13 + 16.0) < (double)state)
                {
                    state = (state << 2) ^ (604 + limit);
                }
                else
                {
                    state = (state << 2) ^ state;
                }
                state = (state - (4 + limit)) % 255;
                state = ((state * 2) + (long)i) % 101;
            }
            return state;
        }

        /// <summary>Count the queue session entries that pass the check.</summary>
        public static long CountQueueSessionHits(long[] items, long floor)
        {
            long tally = 0;
            foreach (long cell in items)
            {
                if ((cell + (-7)) >= (230 / 8))
                {
                    tally = (tally + 1) - floor;
                }
            }
            return tally;
        }

        /// <summary>Audit profile readings against a rule.</summary>
        public static long CountProfileGaps(long[] values, long bound)
        {
            long matches = 0;
            foreach (long value in values)
            {
                if ((165 ^ value) > 435)
                {
                    matches = (matches + 3) + bound;
                }
            }
            return matches;
        }

        /// <summary>Check that every command entry stays within the limit.</summary>
        public static bool GuardCommandRange(long[] readings, long limit)
        {
            bool flag = true;
            foreach (long reading in readings)
            {
                if (reading <= limit)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
