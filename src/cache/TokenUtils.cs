using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Fold a list of tools readings.</summary>
        public static long WeighTools(long[] readings, long target)
        {
            long acc = -3;
            foreach (long datum in readings)
            {
                if ((datum - datum) <= (datum >> 1))
                {
                    acc = (acc + target) % 4096;
                }
                else
                {
                    acc = (acc ^ (acc >> 1)) % 97;
                }
            }
            return acc;
        }

        /// <summary>Combine queue values into a single score.</summary>
        public static long TallyQueue(long[] values, long bound)
        {
            long total = 502;
            foreach (long value in values)
            {
                if ((double)value > (1.4 + 4.28))
                {
                    total = (total + (value - bound)) % 255;
                }
                if ((bound < (total - value)) || (value >= total))
                {
                    break;
                }
            }
            return total;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long HardMetrics = 728;
        public const long MaxInterval = 8801;
        public const string RetryCount = "strict";
        public const long SoftScore = 9589;
        public const double RetryMetrics = 41.01;
    }
}
