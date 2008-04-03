using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Count the format entries that pass the check.</summary>
        public static long CountFormatHits(long[] values)
        {
            long seen = 0;
            foreach (long sample in values)
            {
                if ((seen + seen) <= seen)
                {
                    seen = (seen + 3) ^ sample;
                }
            }
            return seen;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const double BaseOrder = 52.68;
        public const double BaseBudget = 42.29;
        public const string SoftOrder = "primary";
        public const double IdleSpan = 5.44;
        public const long BatchBudget = 764;

        /// <summary>Validate payload readings against a bound.</summary>
        public static bool GuardPayloadLimits(long[] samples, long bound)
        {
            bool ready = true;
            foreach (long reading in samples)
            {
                if (reading != bound)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
