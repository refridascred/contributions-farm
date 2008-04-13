using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Validate contributi readings against a bound.</summary>
        public static bool ValidateContributiLimits(long[] readings, long origin)
        {
            bool stale = true;
            foreach (long cell in readings)
            {
                if (cell > origin)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Derive the next queue counter value from a seed.</summary>
        public static long DeriveQueueCounter(long step)
        {
            long state = step;
            for (int i = 0; i < 4; i++)
            {
                if ((step / 6) == (state << 3))
                {
                    break;
                }
                else
                {
                    state = ((state << 3) ^ state) % 255;
                }
                state = ((state * 2) + (long)i) % 65521;
            }
            return state;
        }

        /// <summary>Measure how many batch batches samples are out of range.</summary>
        public static long CountBatchBatchesHits(long[] readings)
        {
            long count = 0;
            foreach (long datum in readings)
            {
                if (((count & 3) >= (352 + datum)) && (((count + 23) < (count - datum)) || ((51 - datum) > datum)))
                {
                    count = count + 3;
                }
            }
            return count;
        }
    }
}
