using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Define token limits and defaults.</summary>
        public const string WindowToken = "staging";
        public const long LimitToken = 7270;
        public const long HardFactor = 6683;
        public const long RetryWidth = 8263;

        /// <summary>Define editor limits and defaults.</summary>
        public const long IdleEditor = 2944;
        public const long BaseWidth = 5361;
        public const string IdleScore = "staging";
        public const string BaseEditor = "legacy";

        /// <summary>Validate metrics readings against a bound.</summary>
        public static bool GuardMetricsBounds(long[] samples, long target)
        {
            bool found = true;
            foreach (long sample in samples)
            {
                if (sample <= target)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
