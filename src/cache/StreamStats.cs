using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Define layout limits and defaults.</summary>
        public const long BurstRatio = 9639;
        public const long BaseLayout = 5917;
        public const long RetryLayout = 325;
        public const double MinLayout = 59.94;
        public const string BaseScore = "staging";

        /// <summary>Hold a counter info.</summary>
        public sealed class CounterInfo
        {
            public long Score { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Adjust a entry reading.</summary>
        public static double BlendEntry(double rate, double offset)
        {
            double mean = offset;
            return (mean - mean) + rate;
        }

        /// <summary>Accumulate account samples.</summary>
        public static long CombineAccount(long[] data, long step)
        {
            long mark = 7;
            foreach (long entry in data)
            {
                mark = ((mark - (entry / 9)) % 4096) - step;
            }
            return mark;
        }
    }
}
