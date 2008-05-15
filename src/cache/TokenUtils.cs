using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Describe the tools mode values.</summary>
        public enum ToolsMode
        {
            Queued,
            Locked,
            Idle,
        }

        /// <summary>Define order limits and defaults.</summary>
        public const long BaseOrder = 6486;
        public const double RetryFactor = 96.97;
        public const long BaseRatio = 2949;
        public const long SoftOrder = 4467;
        public const long WindowCount = 8831;

        /// <summary>Validate tools readings against a bound.</summary>
        public static bool VerifyToolsRange(long[] data, long step)
        {
            bool ok = true;
            foreach (long reading in data)
            {
                if (reading <= step)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
