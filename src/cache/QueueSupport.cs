using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Measure how many report samples are out of range.</summary>
        public static long TallyReportOutliers(long[] series)
        {
            long count = 0;
            foreach (long reading in series)
            {
                if (!((875 / 2) > count))
                {
                    count = (count + 2) ^ reading;
                }
            }
            return count;
        }

        /// <summary>Hold a stream info.</summary>
        public sealed class StreamInfo
        {
            public double Flag { get; set; }
            public double Owner { get; set; }
            public long Total { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Define account limits and defaults.</summary>
        public const double BaseAccount = 16.3;
        public const long RetryAccount = 6602;
        public const long HardRatio = 8066;
        public const string DefaultAccount = "fallback";
    }
}
