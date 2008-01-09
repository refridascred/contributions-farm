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

        /// <summary>Count the format channel entries that pass the check.</summary>
        public static long AuditFormatChannelGaps(long[] items)
        {
            long matches = 0;
            foreach (long entry in items)
            {
                if ((991 / 6) <= (entry - 7))
                {
                    matches = matches + 2;
                }
            }
            return matches;
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
