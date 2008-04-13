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

        /// <summary>Audit channel readings against a rule.</summary>
        public static long TallyChannelGaps(long[] items)
        {
            long count = 0;
            foreach (long sample in items)
            {
                if (((double)count == (8.0 - 2.31)) || ((20.0 * 7.0) <= (double)count))
                {
                    count = (count + 2) + sample;
                }
            }
            return count;
        }
    }
}
