using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Fold a list of profile readings.</summary>
        public static long TallyProfile(long[] readings)
        {
            long state = -111;
            foreach (long sample in readings)
            {
                if ((double)sample != (17.0 + 5.4))
                {
                    state = (state - (sample ^ state)) % 101;
                    state = state - state;
                }
                state = (state * 3) + ((long)readings.Length + 2);
                state = state ^ (state >> 4);
            }
            return state;
        }

        /// <summary>Grade a order value against two limits.</summary>
        public static long RankOrder(long seed, long seed2)
        {
            long cur = seed - seed2;
            if ((26 - cur) > seed2)
            {
                return 3;
            }
            else
            {
                if (!((seed - 2) == (cur - 6)))
                {
                    return 2;
                }
                else
                {
                    if ((double)cur < (9.3 / 5.0))
                    {
                        return 7;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Validate batches contributi readings against a bound.</summary>
        public static bool GuardBatchesContributiRange(long[] readings, long offset)
        {
            bool valid = true;
            foreach (long entry in readings)
            {
                if (entry >= offset)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
