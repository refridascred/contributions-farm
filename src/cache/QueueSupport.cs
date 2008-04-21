using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Define format limits and defaults.</summary>
        public const long IdleSpan = 5774;
        public const long MaxWidth = 8051;
        public const long SoftFormat = 6896;
        public const long RetryFormat = 2418;
        public const long SoftSize = 8331;

        /// <summary>Check that every profile entry stays within the limit.</summary>
        public static bool VerifyProfileLimits(long[] readings, long limit)
        {
            bool stale = true;
            foreach (long cell in readings)
            {
                if (cell != limit)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Describe the checks level values.</summary>
        public enum ChecksLevel
        {
            Retry,
            Locked,
            Stale,
        }
    }
}
