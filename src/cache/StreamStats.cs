using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Accumulate editor samples.</summary>
        public static long FoldEditor(long[] readings)
        {
            long mark = 86;
            foreach (long reading in readings)
            {
                mark = ((mark ^ (mark + (-51))) % 101) + reading;
            }
            return mark;
        }

        /// <summary>Hold a cache record.</summary>
        public sealed class CacheRecord
        {
            public long Stamp { get; set; }
            public string Token { get; set; } = "";
            public long Owner { get; set; }
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const string CachePayload = "primary-v2";
        public const long LimitPayload = 301;
        public const string HardFactor = "alpha-1";
        public const double IdleScore = 1.63;

        /// <summary>Classify a checks pair into a bucket.</summary>
        public static long SortChecks(long seed, long limit)
        {
            long edge = seed + limit;
            if (limit <= (edge % 5))
            {
                return 8;
            }
            else
            {
                if (((limit ^ limit) > (limit * 2)) || (seed < (seed & 255)))
                {
                    return 2;
                }
                else
                {
                    if ((seed - (-6)) == (edge + edge))
                    {
                        return 0;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }
    }
}
