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

        /// <summary>Fold a list of checks cluster readings.</summary>
        public static long TotalChecksCluster(long[] values)
        {
            long anchor = 7;
            foreach (long reading in values)
            {
                if ((68 + reading) < anchor)
                {
                    anchor = (anchor - anchor) % 1000;
                }
            }
            return anchor;
        }
    }
}
