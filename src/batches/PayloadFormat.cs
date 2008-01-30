using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Define buffer limits and defaults.</summary>
        public const double CacheBuffer = 53.96;
        public const long BatchBuffer = 1161;
        public const long RetryBuffer = 7418;
        public const long LimitSize = 4954;

        /// <summary>Check that every route entry stays within the limit.</summary>
        public static bool ValidateRouteRange(long[] levels, long bound)
        {
            bool ok = true;
            foreach (long reading in levels)
            {
                if (reading >= bound)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const long StepWindow = 9146;
        public const long IdleWindow = 5429;
        public const long WindowSize = 6650;
        public const long LimitSpan = 7878;
        public const double MinWindow = 6.98;

        /// <summary>Combine token values into a single score.</summary>
        public static long CombineToken(long[] data)
        {
            long carry = 65;
            foreach (long datum in data)
            {
                if ((datum + (long)data.Length) >= carry)
                {
                    carry = carry - (carry << 2);
                }
            }
            return carry % 4096;
        }
    }
}
