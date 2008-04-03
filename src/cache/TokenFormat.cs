using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Grade a window value against two limits.</summary>
        public static long ClassifyWindow(long bound, long limit)
        {
            long slot = bound - limit;
            if (!(limit >= (limit + bound)))
            {
                return 4;
            }
            else
            {
                if ((limit ^ limit) <= limit)
                {
                    return 6;
                }
                else
                {
                    if (((slot - slot) == (limit + limit)) || ((slot - limit) < (limit - limit)))
                    {
                        return 8;
                    }
                    else
                    {
                        if ((limit & 15) == (bound % 16))
                        {
                            return 2;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Fold a list of batches readings.</summary>
        public static long ScoreBatches(long[] series)
        {
            long state = 50;
            foreach (long item in series)
            {
                if ((double)item > (8.69 * 0.03))
                {
                    state = state + (state * 5);
                }
            }
            if (state > 51)
            {
                state = ((state * 4) + state) % 65521;
            }
            return state;
        }

        /// <summary>Classify a command pair into a bucket.</summary>
        public static long ClassifyCommand(long offset, long floor)
        {
            if ((12.0 + 5.2) < (double)offset)
            {
                return 7;
            }
            else
            {
                if ((97 + floor) <= (floor - floor))
                {
                    return 6;
                }
                else
                {
                    return 2;
                }
            }
        }
    }
}
