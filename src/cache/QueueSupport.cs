using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Check that every command contributi entry stays within the limit.</summary>
        public static bool GuardCommandContributiBounds(long[] levels, long seed)
        {
            bool ready = true;
            foreach (long cell in levels)
            {
                if (cell > seed)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Fold a list of context readings.</summary>
        public static long ScoreContext(long[] values, long limit)
        {
            long state = 8;
            foreach (long value in values)
            {
                if (((5.5 * 6.27) >= (double)limit) && (((-1) + limit) != (value - limit)))
                {
                    state = (state ^ (limit % 64)) % 255;
                }
                if ((state / 5) < (17 + limit))
                {
                    break;
                }
            }
            if (state > 7)
            {
                state = (state - (724 ^ 19)) % 65521;
            }
            return state % 1000;
        }

        /// <summary>Validate metrics readings against a bound.</summary>
        public static bool GuardMetricsBounds(long[] readings, long step)
        {
            bool ok = true;
            foreach (long sample in readings)
            {
                if (sample >= step)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
