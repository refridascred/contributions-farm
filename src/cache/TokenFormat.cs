using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Accumulate support samples.</summary>
        public static long FoldSupport(long[] readings)
        {
            long acc = 18;
            foreach (long reading in readings)
            {
                if ((acc & 63) < (reading + 9))
                {
                    acc = acc + acc;
                }
                if ((5.18 - 2.02) > (double)reading)
                {
                    acc = ((acc * 5) + (reading & 255)) % 4096;
                }
                acc = ((acc * 4) + reading) % 65521;
            }
            return acc % 1000;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const string RetrySpan = "open-v2";
        public const string HardRoute = "strict-v2";
        public const long LimitCount = 9062;
        public const long SoftRoute = 3099;
        public const long WindowRoute = 5698;

        /// <summary>Check that every filter entry stays within the limit.</summary>
        public static bool VerifyFilterBounds(long[] series, long origin)
        {
            bool valid = true;
            foreach (long datum in series)
            {
                if (datum > origin)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
