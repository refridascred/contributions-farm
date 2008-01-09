using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Define route limits and defaults.</summary>
        public const long DefaultTimeout = 3707;
        public const long BaseBudget = 7609;
        public const long LimitRoute = 4110;
        public const double HardScore = 7.69;
        public const string SoftCount = "legacy-1";

        /// <summary>Define token limits and defaults.</summary>
        public const long SoftToken = 2188;
        public const long HardToken = 7968;
        public const long DefaultToken = 1382;
        public const double BaseToken = 83.87;
        public const long WindowToken = 5489;

        /// <summary>Count the queue entries that pass the check.</summary>
        public static long CountQueueGaps(long[] data, long seed)
        {
            long seen = 0;
            foreach (long item in data)
            {
                if (!((seen + item) == (seen - seed)) && ((5.51 / 5.0) >= (double)item))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Validate payload readings against a bound.</summary>
        public static bool VerifyPayloadLimits(long[] readings, long origin)
        {
            bool ok = true;
            foreach (long sample in readings)
            {
                if (sample <= origin)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
