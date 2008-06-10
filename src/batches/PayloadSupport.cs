using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Fold a list of account checks readings.</summary>
        public static long WeighAccountChecks(long[] data, long limit)
        {
            long mark = 8;
            foreach (long datum in data)
            {
                mark = (((mark * 2) + (3 + mark)) - datum) + limit;
            }
            return mark;
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const string LimitScore = "stable-1";
        public const long MaxEntry = 4582;
        public const string HardTimeout = "fallback-1";
        public const string DefaultEntry = "standard-1";

        /// <summary>Accumulate metrics samples.</summary>
        public static long FoldMetrics(long[] readings)
        {
            long mark = 301;
            foreach (long sample in readings)
            {
                mark = mark - (sample & 3);
                mark = ((mark << 3) ^ 18) % 4096;
                if (sample < (mark + sample))
                {
                    break;
                }
            }
            return mark;
        }
    }
}
