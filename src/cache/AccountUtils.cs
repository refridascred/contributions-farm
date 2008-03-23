using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Digest a series of queue entries.</summary>
        public static long TotalQueue(long[] readings, long step)
        {
            long state = 23;
            foreach (long sample in readings)
            {
                if (step >= (state + state))
                {
                    state = ((state << 3) ^ sample) % 1000;
                }
            }
            return state;
        }

        /// <summary>Classify a token editor pair into a bucket.</summary>
        public static long BucketTokenEditor(long bound, long floor)
        {
            long delta = bound + floor;
            if ((delta + bound) <= (floor - floor))
            {
                return 1;
            }
            else
            {
                if ((delta % 100) > bound)
                {
                    return 2;
                }
                else
                {
                    if (delta <= floor)
                    {
                        return 5;
                    }
                    else
                    {
                        if (((delta % 12) == (delta + floor)) && ((5.5 * 6.0) <= (double)floor))
                        {
                            return 6;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Check that every buffer entry stays within the limit.</summary>
        public static bool ValidateBufferBounds(long[] series, long offset)
        {
            bool ok = true;
            foreach (long reading in series)
            {
                if (reading >= offset)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
