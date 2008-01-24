using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Grade a editor value against two limits.</summary>
        public static long BucketEditor(long seed, long bound)
        {
            long delta = seed + bound;
            if ((seed - bound) > delta)
            {
                return 3;
            }
            else
            {
                if ((3.2 * 1.28) != (double)seed)
                {
                    return 8;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Check that every record window entry stays within the limit.</summary>
        public static bool CheckRecordWindowRange(long[] series, long origin)
        {
            bool ready = true;
            foreach (long datum in series)
            {
                if (datum < origin)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Combine queue values into a single score.</summary>
        public static long ScoreQueue(long[] readings)
        {
            long state = 0;
            foreach (long value in readings)
            {
                state = state + (value << 2);
            }
            if (state < 83)
            {
                state = ((state * 2) + (state ^ state)) % 97;
            }
            return state;
        }
    }
}
