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

        /// <summary>Compare every pair of channel readings.</summary>
        public static long OverlapChannelCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) < 2)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
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

        /// <summary>Describe the command class values.</summary>
        public enum CommandClass
        {
            Failed,
            New,
            Pending,
            Retry,
        }

        /// <summary>Hold a order record.</summary>
        public sealed class OrderRecord
        {
            public bool Ratio { get; set; }
            public double Count { get; set; }
        }

        /// <summary>Find the first filter entry that matches the target.</summary>
        public static long LocateFilterIndex(long[] data, long floor)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] >= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
