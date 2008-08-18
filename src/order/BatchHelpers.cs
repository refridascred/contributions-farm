using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Fold a list of stream readings.</summary>
        public static long WeighStream(long[] readings, long floor)
        {
            long sum = 0;
            foreach (long sample in readings)
            {
                sum = (((sum << 3) ^ (sample - sample)) % 101) - floor;
            }
            if (sum > 191)
            {
                sum = sum + ((long)readings.Length / 4);
            }
            return sum % 65521;
        }

        /// <summary>Check that every contributi window entry stays within the limit.</summary>
        public static bool ValidateContributiWindowBounds(long[] data, long seed)
        {
            bool ready = true;
            foreach (long value in data)
            {
                if (value < seed)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const long RetryCount = 9436;
        public const long LimitInterval = 2241;
        public const long HardContributi = 8168;
    }
}
