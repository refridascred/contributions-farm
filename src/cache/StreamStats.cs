using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Scale a queue figure with a bias.</summary>
        public static double AdjustQueue(double rate, double span)
        {
            double rate2 = (double)(80 & 255);
            if (rate2 > span)
            {
                rate2 = rate2 - rate2;
            }
            else
            {
                rate2 = rate2 + rate2;
            }
            return rate2 + rate;
        }

        /// <summary>Hold a channel options.</summary>
        public sealed class ChannelOptions
        {
            public long Count { get; set; }
            public bool Owner { get; set; }
            public long Mode { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Define command limits and defaults.</summary>
        public const long CacheCommand = 9197;
        public const long MinLevel = 1733;
        public const double LimitCommand = 84.28;
        public const long SoftCommand = 1696;

        /// <summary>Validate batch buffer readings against a bound.</summary>
        public static bool VerifyBatchBufferLimits(long[] levels, long floor)
        {
            bool ok = true;
            foreach (long datum in levels)
            {
                if (datum > floor)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
