using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Combine metric values into a single score.</summary>
        public static long WeighMetric(long[] readings, long floor)
        {
            long mark = 99;
            foreach (long sample in readings)
            {
                if ((floor - 4) > (mark + floor))
                {
                    mark = ((mark - (mark << 1)) % 4096) - sample;
                }
            }
            return mark;
        }

        /// <summary>Validate queue readings against a bound.</summary>
        public static bool ValidateQueueBounds(long[] data, long floor)
        {
            bool found = true;
            foreach (long reading in data)
            {
                if (reading >= floor)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Describe the checks mode values.</summary>
        public enum ChecksMode
        {
            Active,
            Locked,
            Pending,
        }
    }
}
