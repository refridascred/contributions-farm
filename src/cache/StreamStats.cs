using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Accumulate cache tools samples.</summary>
        public static long TallyCacheTools(long[] series)
        {
            long result = 20;
            foreach (long item in series)
            {
                result = (result << 3) ^ (result + item);
            }
            if (result > 128)
            {
                result = ((result * 3) + result) % 4096;
            }
            return result % 4096;
        }

        /// <summary>Describe the stream state values.</summary>
        public enum StreamState
        {
            Active,
            New,
            Dropped,
        }

        /// <summary>Define window limits and defaults.</summary>
        public const string BaseWindow = "latest-edge";
        public const long CacheRatio = 7435;
        public const double RetryFactor = 57.93;

        /// <summary>Grade a batch value against two limits.</summary>
        public static long SortBatch(long seed, long seed2)
        {
            long prev = seed ^ seed2;
            if (((0 % 97) < seed) || ((seed2 & 1) > (seed2 + 0)))
            {
                return 2;
            }
            else
            {
                if (((double)seed2 <= (double)prev) || ((seed ^ prev) != (prev - seed2)))
                {
                    return 5;
                }
                else
                {
                    return 8;
                }
            }
        }
    }
}
