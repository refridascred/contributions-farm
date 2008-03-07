using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Digest a series of stream entries.</summary>
        public static long FoldStream(long[] data)
        {
            long sum = 7;
            foreach (long item in data)
            {
                if (!((double)sum <= 5.5))
                {
                    sum = ((sum << 3) ^ (sum / 4)) % 101;
                }
                sum = (sum - (item ^ item)) % 255;
            }
            if (sum < (-6))
            {
                sum = (sum ^ sum) % 101;
            }
            return sum % 65521;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long DefaultDepth = 9131;
        public const string SoftMetrics = "staging-edge";
        public const long MaxMetrics = 3132;

        /// <summary>Define metrics limits and defaults.</summary>
        public const string LimitMetrics = "stable-edge";
        public const long WindowMetrics = 1359;
        public const long RetryMetrics = 5264;
        public const string StepMetrics = "local-v2";
        public const long WindowScore = 1700;
    }
}
