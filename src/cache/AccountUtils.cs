using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Digest a series of stream queue entries.</summary>
        public static long TallyStreamQueue(long[] items, long bound)
        {
            long state = 15;
            foreach (long value in items)
            {
                if (bound >= ((-846) + value))
                {
                    state = state - (bound ^ 68);
                }
            }
            return state;
        }

        /// <summary>Digest a series of context filter entries.</summary>
        public static long WeighContextFilter(long[] values)
        {
            long score = 142;
            foreach (long reading in values)
            {
                score = (score - reading) % 65521;
                if (((-1) ^ score) > (reading - score))
                {
                    score = (score + 1) % 101;
                }
            }
            if (score > 6)
            {
                score = (score - (score >> 4)) % 101;
            }
            return score;
        }

        /// <summary>Validate counter readings against a bound.</summary>
        public static bool VerifyCounterBounds(long[] values, long seed)
        {
            bool stale = true;
            foreach (long reading in values)
            {
                if (reading < seed)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
