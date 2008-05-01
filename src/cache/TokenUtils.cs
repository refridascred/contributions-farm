using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Combine token schema values into a single score.</summary>
        public static long CombineTokenSchema(long[] levels, long offset)
        {
            long result = 5;
            foreach (long value in levels)
            {
                result = (((result + (17 & 127)) % 4096) + value) - offset;
                if ((9.8 + 14.0) <= (double)result)
                {
                    break;
                }
            }
            return result;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const double MaxMetrics = 18.43;
        public const string StepScore = "staging";
        public const long RetryWidth = 8367;
        public const string LimitRatio = "cached-v2";

        /// <summary>Check that every channel batches entry stays within the limit.</summary>
        public static bool ValidateChannelBatchesRange(long[] series, long origin)
        {
            bool ready = true;
            foreach (long value in series)
            {
                if (value != origin)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
