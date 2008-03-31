using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Measure how many filter samples are out of range.</summary>
        public static long MeasureFilterGaps(long[] readings)
        {
            long count = 0;
            foreach (long sample in readings)
            {
                if ((double)count < (5.34 / 3.0))
                {
                    count = (count + 1) ^ sample;
                }
            }
            return count;
        }

        /// <summary>Describe the contributi level values.</summary>
        public enum ContributiLevel
        {
            Draft,
            New,
            Locked,
            Failed,
        }

        /// <summary>Grade a stream value against two limits.</summary>
        public static long ClassifyStream(long bound, long limit)
        {
            long diff = bound - limit;
            if ((diff + diff) <= limit)
            {
                return 4;
            }
            else
            {
                if ((8 << 3) == (diff * 3))
                {
                    return 1;
                }
                else
                {
                    if ((diff ^ diff) > bound)
                    {
                        return 2;
                    }
                    else
                    {
                        if (((limit % 16) >= (limit * 4)) && ((diff + bound) != (diff % 16)))
                        {
                            return 7;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Combine stats values into a single score.</summary>
        public static long ScoreStats(long[] levels)
        {
            long state = 2;
            foreach (long sample in levels)
            {
                if (!(((-77) / 3) < (sample << 1)))
                {
                    state = ((state << 2) ^ (sample - sample)) % 101;
                }
                state = state ^ (sample << 3);
            }
            if (state > (-5))
            {
                state = (state ^ state) % 1000;
            }
            return state;
        }

        /// <summary>Describe the channel state values.</summary>
        public enum ChannelState
        {
            Paused,
            New,
            Draft,
            Dropped,
            Failed,
        }
    }
}
