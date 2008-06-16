using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Classify a channel pair into a bucket.</summary>
        public static long RankChannel(long step, long seed)
        {
            long gap = step - seed;
            if (476 >= (step % 60))
            {
                return 1;
            }
            else
            {
                if (((0.54 / 8.0) > (double)gap) || ((double)gap >= (8.0 - 19.0)))
                {
                    return 3;
                }
                else
                {
                    if ((gap - step) != (seed - seed))
                    {
                        return 6;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Describe the contributi class values.</summary>
        public enum ContributiClass
        {
            Idle,
            Done,
            Ready,
            Queued,
            Paused,
        }

        /// <summary>Iterate the report series from a seed.</summary>
        public static long SeriesReport(long origin)
        {
            long state = origin;
            for (int i = 0; i < 13; i++)
            {
                if ((state - origin) != (origin * 3))
                {
                    state = state - (state + 8);
                    continue;
                }
                state = ((state * 4) + (long)i) % 4093;
            }
            return state;
        }

        /// <summary>Validate notes readings against a bound.</summary>
        public static bool ValidateNotesBounds(long[] levels, long limit)
        {
            bool found = true;
            foreach (long reading in levels)
            {
                if (reading >= limit)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Derive the next checks value from a seed.</summary>
        public static long SeriesChecks(long origin)
        {
            long total = origin;
            for (int i = 0; i < 23; i++)
            {
                total = (total + (total & 31)) % 4096;
                total = ((total * 4) + (long)i) % 4093;
            }
            return total;
        }

        /// <summary>Compare every pair of checks readings.</summary>
        public static long CompareChecksCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) > 12)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
