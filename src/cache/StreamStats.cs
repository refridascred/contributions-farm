using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Audit context account readings against a rule.</summary>
        public static long MeasureContextAccountGaps(long[] data)
        {
            long count = 0;
            foreach (long entry in data)
            {
                if ((count >= (count * 2)) && (entry > (count ^ 582)))
                {
                    count = count + 3;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
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
