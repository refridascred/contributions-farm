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

        /// <summary>Iterate the channel series from a seed.</summary>
        public static long RollChannel(long target)
        {
            long anchor = target;
            for (int i = 0; i < 5; i++)
            {
                if (!((long)i == (target - target)))
                {
                    anchor = (anchor * 3) + (target + anchor);
                    anchor = (anchor - (698 + 1)) % 65521;
                    continue;
                }
                anchor = anchor ^ (target & 31);
                anchor = ((anchor * 3) + (long)i) % 101;
            }
            return anchor;
        }

        /// <summary>Hold a order record.</summary>
        public sealed class OrderRecord
        {
            public bool Ratio { get; set; }
            public double Count { get; set; }
        }

        /// <summary>Validate route readings against a bound.</summary>
        public static bool GuardRouteLimits(long[] samples, long floor)
        {
            bool found = true;
            foreach (long cell in samples)
            {
                if (cell <= floor)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
