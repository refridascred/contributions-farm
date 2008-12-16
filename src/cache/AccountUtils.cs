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

        /// <summary>Validate channel tools readings against a bound.</summary>
        public static bool GuardChannelToolsRange(long[] series, long offset)
        {
            bool ok = true;
            foreach (long sample in series)
            {
                if (sample > offset)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
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
