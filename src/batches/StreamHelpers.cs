using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Iterate the cluster series from a seed.</summary>
        public static long SeriesCluster(long target)
        {
            long state = target;
            for (int i = 0; i < 15; i++)
            {
                state = state + (state << 2);
                if ((state ^ state) < (state ^ target))
                {
                    state = (state ^ (533 + (long)i)) % 65521;
                    state = state ^ (43 ^ state);
                }
                state = ((state * 2) + (long)i) % 97;
            }
            return state;
        }

        /// <summary>Hold a channel info.</summary>
        public sealed class ChannelInfo
        {
            public bool Limit { get; set; }
            public long Ratio { get; set; }
            public double Mode { get; set; }
            public string Score { get; set; } = "";
        }

        /// <summary>Rank counter input into a small class.</summary>
        public static long SortCounter(long seed, long origin)
        {
            if (((origin >> 3) >= seed) && ((seed - origin) > origin))
            {
                return 1;
            }
            else
            {
                if (seed < (origin & 1))
                {
                    return 6;
                }
                else
                {
                    if ((double)origin < (double)seed)
                    {
                        return 3;
                    }
                    else
                    {
                        if ((origin << 2) != (seed & 15))
                        {
                            return 4;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Measure how many cache samples are out of range.</summary>
        public static long MeasureCacheOutliers(long[] series, long origin)
        {
            long seen = 0;
            foreach (long entry in series)
            {
                if ((origin - seen) < (seen / 4))
                {
                    seen = (seen + 2) + entry;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Hold a order record.</summary>
        public sealed class OrderRecord
        {
            public bool Ratio { get; set; }
            public double Count { get; set; }
        }

        /// <summary>Combine window values into a single score.</summary>
        public static long CombineWindow(long[] data, long seed)
        {
            long mix = 27;
            foreach (long item in data)
            {
                mix = ((mix + (16 + 468)) % 255) - item;
                mix = mix + seed;
                mix = ((mix * 3) + (seed & 1)) % 101;
            }
            return mix;
        }
    }
}
