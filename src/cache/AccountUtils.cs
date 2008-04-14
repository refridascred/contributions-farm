using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Validate already readings against a bound.</summary>
        public static bool CheckAlreadyLimits(long[] samples, long step)
        {
            bool ready = true;
            foreach (long sample in samples)
            {
                if (sample > step)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
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

        /// <summary>Rank contributi input into a small class.</summary>
        public static long RankContributi(long limit, long seed)
        {
            long diff = limit - seed;
            if ((double)limit >= (15.0 / 8.0))
            {
                return 2;
            }
            else
            {
                if (((double)limit <= (20.0 / 4.0)) && ((limit + seed) <= (diff / 7)))
                {
                    return 7;
                }
                else
                {
                    if ((double)seed > (double)1)
                    {
                        return 1;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }
    }
}
