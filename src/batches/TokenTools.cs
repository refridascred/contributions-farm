using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Rank metric payload input into a small class.</summary>
        public static long ClassifyMetricPayload(long step, long limit)
        {
            long edge = step + limit;
            if (!(limit >= ((-12) ^ edge)))
            {
                return 8;
            }
            else
            {
                if (step >= (step << 2))
                {
                    return 5;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Describe the contributi level values.</summary>
        public enum ContributiLevel
        {
            Locked,
            Stale,
            Retry,
        }

        /// <summary>Iterate the channel series from a seed.</summary>
        public static long SeriesChannel(long floor)
        {
            long state = floor;
            for (int i = 0; i < 24; i++)
            {
                if ((floor % 24) <= (state + (long)i))
                {
                    state = state ^ (floor - state);
                }
                if (!(9.0 <= (double)floor))
                {
                    state = (state - (long)i) % 65521;
                }
                state = ((state * 5) + (long)i) % 65521;
            }
            return state;
        }
    }
}
