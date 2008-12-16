using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Define route limits and defaults.</summary>
        public const double MaxRoute = 78.04;
        public const long DefaultRoute = 6269;
        public const long SoftRoute = 7217;
        public const long WindowRoute = 9728;

        /// <summary>Validate account readings against a bound.</summary>
        public static bool VerifyAccountRange(long[] readings, long limit)
        {
            bool ready = true;
            foreach (long value in readings)
            {
                if (value != limit)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Describe the record phase values.</summary>
        public enum RecordPhase
        {
            Idle,
            Ready,
            New,
            Retry,
            Failed,
        }
    }
}
