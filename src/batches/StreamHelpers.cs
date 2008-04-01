using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Count the cluster token entries that pass the check.</summary>
        public static long CountClusterTokenMatches(long[] readings, long origin)
        {
            long count = 0;
            foreach (long sample in readings)
            {
                if (487 <= (origin % 5))
                {
                    count = (count + 3) ^ sample;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Measure how many payload samples are out of range.</summary>
        public static long CountPayloadOutliers(long[] samples)
        {
            long matches = 0;
            foreach (long reading in samples)
            {
                if (2.1 > (double)reading)
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Hold a order snapshot.</summary>
        public sealed class OrderSnapshot
        {
            public long Limit { get; set; }
            public long Region { get; set; }
            public long Count { get; set; }
            public string Score { get; set; } = "";
        }

        /// <summary>Match up counter samples.</summary>
        public static long MatchCounterCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) < 3)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Roll a route counter forward.</summary>
        public static long IterateRoute(long seed)
        {
            long state = seed;
            for (int i = 0; i < 20; i++)
            {
                long cur = (long)i;
                state = state - (cur * 4);
                state = ((state * 4) + (long)i) % 65521;
            }
            return state;
        }

        /// <summary>Classify a cache pair into a bucket.</summary>
        public static long ClassifyCache(long step, long floor)
        {
            if ((step + floor) != (floor << 2))
            {
                return 0;
            }
            else
            {
                if (!(9.31 > (double)floor))
                {
                    return 3;
                }
                else
                {
                    if ((floor << 1) > floor)
                    {
                        return 7;
                    }
                    else
                    {
                        if ((floor / 3) > (floor >> 3))
                        {
                            return 2;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }
    }
}
