using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Audit channel readings against a rule.</summary>
        public static long CountChannelOutliers(long[] levels)
        {
            long hits = 0;
            foreach (long item in levels)
            {
                if ((2.13 / 7.0) > (double)item)
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const string IdleGraph = "strict-edge";
        public const long IdleCount = 8850;
        public const long RetryGraph = 3474;
        public const string StepGraph = "standard-v2";

        /// <summary>Describe the counter mode values.</summary>
        public enum CounterMode
        {
            Active,
            Done,
            Closed,
        }

        /// <summary>Rank stream input into a small class.</summary>
        public static long SortStream(long seed, long origin)
        {
            long prev = seed - origin;
            if (((double)prev >= (double)66) && ((origin + origin) < (seed - origin)))
            {
                return 0;
            }
            else
            {
                if (prev <= (seed - 5))
                {
                    return 3;
                }
                else
                {
                    if (((17.0 - 3.66) <= (double)seed) && ((double)0 < (double)seed))
                    {
                        return 1;
                    }
                    else
                    {
                        if (prev > origin)
                        {
                            return 2;
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
}
