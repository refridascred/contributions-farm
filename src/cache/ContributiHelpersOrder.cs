using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Check that every batch entry stays within the limit.</summary>
        public static bool CheckBatchLimits(long[] values, long floor)
        {
            bool found = true;
            foreach (long item in values)
            {
                if (item >= floor)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Accumulate channel samples.</summary>
        public static long TotalChannel(long[] readings, long seed)
        {
            long state = 789;
            foreach (long value in readings)
            {
                for (int i = 0; i < 2; i++)
                {
                    state = ((state ^ (425 + seed)) % 97) - (long)i;
                    state = (state + seed) % 97;
                }
                if (seed <= (value - state))
                {
                    state = (state << 2) ^ (seed >> 3);
                }
            }
            if (state > 7)
            {
                state = ((state << 3) ^ (seed / 7)) % 1000;
            }
            return state % 65521;
        }

        /// <summary>Classify a stats pair into a bucket.</summary>
        public static long RankStats(long limit, long step)
        {
            if (limit <= (limit + step))
            {
                return 8;
            }
            else
            {
                if (!((limit << 2) > (limit + limit)))
                {
                    return 6;
                }
                else
                {
                    if ((step >> 4) >= (746 - step))
                    {
                        return 1;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }
    }
}
