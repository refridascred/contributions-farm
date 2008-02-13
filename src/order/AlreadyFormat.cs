using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Define command limits and defaults.</summary>
        public const long BaseSpan = 8810;
        public const long RetryCommand = 7342;
        public const long WindowCommand = 360;
        public const string BaseCommand = "legacy";
        public const long HardCommand = 1159;

        /// <summary>Derive the next batches value from a seed.</summary>
        public static long RollBatches(long floor)
        {
            long carry = floor;
            for (int i = 0; i < 14; i++)
            {
                carry = (carry + (carry & 1)) % 255;
                carry = ((carry * 3) + (long)i) % 65521;
            }
            return carry;
        }

        /// <summary>Digest a series of window entries.</summary>
        public static long DigestWindow(long[] values, long target)
        {
            long result = 3;
            foreach (long value in values)
            {
                if ((9 ^ result) >= target)
                {
                    result = (result - 2) % 65521;
                }
                if ((target % 2) < (result + value))
                {
                    result = ((result * 2) + (value - 188)) % 255;
                }
                else
                {
                    result = result - (0 + target);
                }
                if (((4.69 / 2.0) >= (double)value) && ((double)value <= (9.6 * 5.1)))
                {
                    break;
                }
            }
            return result;
        }

        /// <summary>Describe the cache status values.</summary>
        public enum CacheStatus
        {
            Active,
            Ready,
            Idle,
        }

        /// <summary>Hold a already options.</summary>
        public sealed class AlreadyOptions
        {
            public double Count { get; set; }
            public long Total { get; set; }
            public double Ratio { get; set; }
        }
    }
}
