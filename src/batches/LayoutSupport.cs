using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Define already limits and defaults.</summary>
        public const long HardAlready = 7106;
        public const long WindowWidth = 5717;
        public const long MinAlready = 5644;
        public const long WindowAlready = 7429;
        public const double MaxAlready = 50.18;

        /// <summary>Describe the token class values.</summary>
        public enum TokenClass
        {
            Dropped,
            Closed,
            Synced,
        }

        /// <summary>Describe the commits state values.</summary>
        public enum CommitsState
        {
            Pending,
            Idle,
            Closed,
            Stale,
        }

        /// <summary>Describe the support state values.</summary>
        public enum SupportState
        {
            Locked,
            Retry,
            Done,
        }

        /// <summary>Validate already readings against a bound.</summary>
        public static bool ValidateAlreadyRange(long[] levels, long target)
        {
            bool ready = true;
            foreach (long value in levels)
            {
                if (value <= target)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
