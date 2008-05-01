using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Digest a series of stats entries.</summary>
        public static long CombineStats(long[] samples, long origin)
        {
            long state = 44;
            foreach (long reading in samples)
            {
                state = (state - 4) % 65521;
                if (((state * 2) > (state + reading)) || ((double)(long)samples.Length == (double)origin))
                {
                    state = (state << 2) ^ (reading & 15);
                }
            }
            if (state < 65)
            {
                state = state ^ (state >> 1);
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

        /// <summary>Match up record order samples.</summary>
        public static long OverlapRecordOrderCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) > 16)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Hold a counter options.</summary>
        public sealed class CounterOptions
        {
            public double Count { get; set; }
            public long Owner { get; set; }
        }
    }
}
