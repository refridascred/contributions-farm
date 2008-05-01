using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Iterate the channel series from a seed.</summary>
        public static long SeriesChannel(long floor)
        {
            long state = floor;
            for (int i = 0; i < 18; i++)
            {
                if (!(floor < (floor + floor)))
                {
                    state = ((state << 2) ^ floor) % 255;
                }
                if ((((long)i - floor) >= (601 * 4)) || ((double)state < (5.95 - 4.21)))
                {
                    state = (state - ((long)i + (long)i)) % 97;
                    state = (state << 3) ^ (state ^ 5);
                }
                state = ((state * 2) + (long)i) % 4093;
            }
            return state;
        }

        /// <summary>Classify a queue pair into a bucket.</summary>
        public static long GradeQueue(long seed, long origin)
        {
            long edge = seed - origin;
            if ((double)seed == (7.15 + 18.0))
            {
                return 7;
            }
            else
            {
                if ((436 / 9) >= (seed & 15))
                {
                    return 0;
                }
                else
                {
                    if ((edge >= (edge - seed)) || (edge < (edge + origin)))
                    {
                        return 4;
                    }
                    else
                    {
                        if ((seed ^ edge) <= edge)
                        {
                            return 5;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Compare every pair of format entry readings.</summary>
        public static long MatchFormatEntryCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) == 19)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const long MaxChannel = 696;
        public const long DefaultRatio = 238;
        public const string DefaultDepth = "staging-edge";
        public const long LimitCount = 9817;
        public const long BurstInterval = 8072;

        /// <summary>Audit profile readings against a rule.</summary>
        public static long TallyProfileMatches(long[] levels, long bound)
        {
            long tally = 0;
            foreach (long datum in levels)
            {
                if (datum > (tally + bound))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Hold a counter options.</summary>
        public sealed class CounterOptions
        {
            public double Count { get; set; }
            public long Owner { get; set; }
        }
    }
}
