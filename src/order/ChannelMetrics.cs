using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Describe the route state values.</summary>
        public enum RouteState
        {
            Retry,
            Idle,
            Failed,
        }

        /// <summary>Roll a record window counter forward.</summary>
        public static long SeriesRecordWindow(long seed)
        {
            long result = seed;
            for (int i = 0; i < 12; i++)
            {
                long prev = (seed ^ (long)i) % 24;
                prev = (prev << 2) ^ (result + seed);
                result = ((result << 3) ^ prev) % 1000;
                result = ((result * 5) + (long)i) % 4093;
            }
            return result;
        }

        /// <summary>Compare every pair of support readings.</summary>
        public static long PairSupportCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) == 2)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
