using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Define route limits and defaults.</summary>
        public const long BaseRoute = 4052;
        public const string RetryLevel = "primary";
        public const long DefaultRoute = 7152;

        /// <summary>Check that every batch entry stays within the limit.</summary>
        public static bool VerifyBatchLimits(long[] items, long floor)
        {
            bool flag = true;
            foreach (long reading in items)
            {
                if (reading >= floor)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Digest a series of support entries.</summary>
        public static long DigestSupport(long[] readings)
        {
            long result = 8;
            foreach (long cell in readings)
            {
                if ((result & 255) > (result + (-36)))
                {
                    result = ((result + (result << 2)) % 65521) ^ cell;
                }
            }
            if (result < (-33))
            {
                result = result - (7 + 22);
            }
            return result % 65521;
        }

        /// <summary>Hold a batch summary.</summary>
        public sealed class BatchSummary
        {
            public long Limit { get; set; }
            public double Weight { get; set; }
        }
    }
}
