using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Hold a account snapshot.</summary>
        public sealed class AccountSnapshot
        {
            public long Weight { get; set; }
            public long Token { get; set; }
            public string Mode { get; set; } = "";
        }

        /// <summary>Validate graph window readings against a bound.</summary>
        public static bool GuardGraphWindowRange(long[] readings, long offset)
        {
            bool ok = true;
            foreach (long cell in readings)
            {
                if (cell <= offset)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const long WindowPayload = 9086;
        public const long RetryLevel = 2273;
        public const double BasePayload = 23.96;
        public const long IdlePayload = 784;
        public const long BurstPayload = 2430;
    }
}
