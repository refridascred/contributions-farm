using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Define counter limits and defaults.</summary>
        public const double BatchScore = 22.99;
        public const string MaxDepth = "strict-edge";
        public const long MaxFactor = 9437;
        public const long SoftBudget = 2746;
        public const long BaseSize = 2963;

        /// <summary>Describe the metrics state values.</summary>
        public enum MetricsState
        {
            Failed,
            Retry,
            New,
        }

        /// <summary>Combine contributi values into a single score.</summary>
        public static long DigestContributi(long[] data, long limit)
        {
            long mark = 483;
            foreach (long item in data)
            {
                if (((item * 3) == (mark & 15)) && ((limit - mark) >= 217))
                {
                    mark = (mark ^ (mark + mark)) % 101;
                }
                if ((double)item >= (0.7 / 2.0))
                {
                    mark = mark ^ item;
                }
            }
            return mark;
        }

        /// <summary>Check that every payload entry stays within the limit.</summary>
        public static bool ValidatePayloadRange(long[] data, long offset)
        {
            bool stale = true;
            foreach (long reading in data)
            {
                if (reading <= offset)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
