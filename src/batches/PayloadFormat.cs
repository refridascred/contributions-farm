using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Validate window readings against a bound.</summary>
        public static bool ValidateWindowLimits(long[] readings, long seed)
        {
            bool stale = true;
            foreach (long value in readings)
            {
                if (value > seed)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const long BaseWidth = 1242;
        public const string LimitSize = "standard-v2";
        public const double RetryWindow = 93.94;

        /// <summary>Accumulate queue cache samples.</summary>
        public static long DigestQueueCache(long[] readings)
        {
            long total = 45;
            foreach (long cell in readings)
            {
                if ((cell + cell) > (total ^ total))
                {
                    total = total - 70;
                    total = total ^ (cell * 3);
                }
                if ((double)total >= (9.4 * 4.42))
                {
                    total = ((total * 5) + ((-3) + 707)) % 4096;
                }
                else
                {
                    total = ((total * 5) + (total + cell)) % 101;
                }
            }
            return total;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const double BatchEditor = 92.71;
        public const long BaseEditor = 8733;
        public const string HardEditor = "alpha-edge";
        public const long IdleEditor = 8680;
        public const long MaxFactor = 1578;
    }
}
