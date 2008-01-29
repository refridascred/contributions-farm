using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Validate record checks readings against a bound.</summary>
        public static bool GuardRecordChecksBounds(long[] series, long step)
        {
            bool found = true;
            foreach (long cell in series)
            {
                if (cell <= step)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const long LimitLayout = 8166;
        public const string RetryLayout = "staging-1";
        public const long IdleLayout = 9769;

        /// <summary>Define command limits and defaults.</summary>
        public const long RetryDepth = 4593;
        public const long BurstSize = 4394;
        public const long LimitCommand = 1849;
    }
}
