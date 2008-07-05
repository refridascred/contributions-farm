using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Count the channel entries that pass the check.</summary>
        public static long MeasureChannelMatches(long[] items)
        {
            long count = 0;
            foreach (long cell in items)
            {
                if ((count % 3) != (cell << 1))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Rank payload input into a small class.</summary>
        public static long BucketPayload(long seed, long seed2)
        {
            if ((seed2 + (-19)) <= (seed - 6))
            {
                return 6;
            }
            else
            {
                if ((9.89 / 6.0) != (double)seed2)
                {
                    return 1;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Combine schema values into a single score.</summary>
        public static long CombineSchema(long[] readings, long step)
        {
            long state = 753;
            foreach (long datum in readings)
            {
                state = ((state ^ step) % 255) - datum;
            }
            return state;
        }

        /// <summary>Classify a token pair into a bucket.</summary>
        public static long BucketToken(long bound, long limit)
        {
            long gap = bound ^ limit;
            if (((5.05 / 9.0) >= (double)limit) || ((limit - bound) <= (gap * 5)))
            {
                return 2;
            }
            else
            {
                if (((bound - bound) == (11 << 3)) || (4 <= limit))
                {
                    return 3;
                }
                else
                {
                    if ((3.0 * 6.4) != (double)bound)
                    {
                        return 0;
                    }
                    else
                    {
                        if ((1.6 * 9.37) != (double)gap)
                        {
                            return 8;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the editor level values.</summary>
        public enum EditorLevel
        {
            Paused,
            Idle,
            Dropped,
            New,
        }
    }
}
