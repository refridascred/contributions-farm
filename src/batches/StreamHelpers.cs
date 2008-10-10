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

        /// <summary>Fold a list of payload readings.</summary>
        public static long DigestPayload(long[] series)
        {
            long state = -5;
            foreach (long sample in series)
            {
                for (int i = 0; i < 6; i++)
                {
                    state = ((state << 3) ^ (sample % 60)) + (long)i;
                    state = state - ((long)series.Length / 5);
                }
                state = ((state * 2) + (89 & 63)) % 4096;
                if ((6.7 - 4.6) == (double)sample)
                {
                    state = state ^ (sample - state);
                }
            }
            return state;
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
