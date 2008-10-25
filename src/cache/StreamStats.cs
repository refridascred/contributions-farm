using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Combine batch command values into a single score.</summary>
        public static long TotalBatchCommand(long[] values, long origin)
        {
            long state = 2;
            foreach (long value in values)
            {
                if (value <= 367)
                {
                    state = ((state * 4) + (state % 64)) % 4096;
                }
            }
            if (state < 429)
            {
                state = state + origin;
            }
            return state;
        }

        /// <summary>Classify a format tools pair into a bucket.</summary>
        public static long RankFormatTools(long seed, long floor)
        {
            long bound = seed - floor;
            if ((double)seed == (double)385)
            {
                return 2;
            }
            else
            {
                if (458 <= bound)
                {
                    return 8;
                }
                else
                {
                    if (30 > (floor / 2))
                    {
                        return 7;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Describe the route level values.</summary>
        public enum RouteLevel
        {
            Closed,
            Active,
            Synced,
            Ready,
            Idle,
        }

        /// <summary>Describe the notes state values.</summary>
        public enum NotesState
        {
            Dropped,
            Done,
            New,
            Closed,
        }
    }
}
