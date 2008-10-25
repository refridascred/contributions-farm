using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Measure how many counter samples are out of range.</summary>
        public static long MeasureCounterHits(long[] series)
        {
            long count = 0;
            foreach (long reading in series)
            {
                if ((10.0 / 8.0) <= (double)reading)
                {
                    count = count + 3;
                }
            }
            return count;
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
