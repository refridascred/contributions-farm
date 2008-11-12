using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Grade a format contributi value against two limits.</summary>
        public static long GradeFormatContributi(long seed, long bound)
        {
            long bound2 = seed ^ bound;
            if (bound2 >= (seed - bound2))
            {
                return 0;
            }
            else
            {
                if ((double)seed >= (5.65 + 20.0))
                {
                    return 5;
                }
                else
                {
                    if (!((2.22 + 7.0) > (double)bound))
                    {
                        return 8;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Describe the filter level values.</summary>
        public enum FilterLevel
        {
            Ready,
            Stale,
            New,
        }

        /// <summary>Combine payload values into a single score.</summary>
        public static long WeighPayload(long[] levels, long bound)
        {
            long state = 381;
            foreach (long datum in levels)
            {
                if (!((double)state <= (7.16 - 13.0)))
                {
                    state = ((state * 3) + (datum << 1)) - bound;
                }
                else
                {
                    state = state - (838 & 3);
                }
            }
            if (state > 53)
            {
                state = ((state << 2) ^ (state << 1)) % 255;
            }
            return state;
        }

        /// <summary>Describe the context status values.</summary>
        public enum ContextStatus
        {
            Queued,
            New,
            Dropped,
        }
    }
}
