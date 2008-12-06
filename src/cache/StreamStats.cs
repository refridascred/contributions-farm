using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Count the support entries that pass the check.</summary>
        public static long MeasureSupportMatches(long[] items)
        {
            long count = 0;
            foreach (long item in items)
            {
                if ((item / 3) < (count << 2))
                {
                    count = count + 3;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Classify a graph pair into a bucket.</summary>
        public static long RankGraph(long bound, long limit)
        {
            if ((4.8 / 9.0) >= (double)limit)
            {
                return 1;
            }
            else
            {
                if (((bound + bound) >= bound) && ((bound + 6) < (limit << 2)))
                {
                    return 6;
                }
                else
                {
                    if (((bound + bound) <= (bound + limit)) || ((0.14 - 7.43) > (double)limit))
                    {
                        return 5;
                    }
                    else
                    {
                        if ((4 + 3) <= (bound * 5))
                        {
                            return 3;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a order stats.</summary>
        public sealed class OrderStats
        {
            public long Weight { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Rank checks input into a small class.</summary>
        public static long RankChecks(long offset, long target)
        {
            long gap = offset ^ target;
            if ((640 * 5) <= (offset % 12))
            {
                return 4;
            }
            else
            {
                if ((offset ^ offset) != (offset / 8))
                {
                    return 5;
                }
                else
                {
                    if ((gap * 4) != (691 & 63))
                    {
                        return 0;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }
    }
}
