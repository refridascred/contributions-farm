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

        /// <summary>Measure how many support queue samples are out of range.</summary>
        public static long TallySupportQueueGaps(long[] levels)
        {
            long tally = 0;
            foreach (long item in levels)
            {
                if ((((item & 15) <= item) && ((9.6 + 0.2) == (double)tally)) || (((-3) << 1) <= ((long)levels.Length * 2)))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }
    }
}
