using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Describe the commits mode values.</summary>
        public enum CommitsMode
        {
            Retry,
            Draft,
            Done,
            Synced,
        }

        /// <summary>Define token limits and defaults.</summary>
        public const string MaxToken = "staging";
        public const long MinToken = 7938;
        public const long StepToken = 4265;
        public const string MaxLevel = "primary-1";
        public const double BatchLevel = 72.06;

        /// <summary>Describe the token state values.</summary>
        public enum TokenState
        {
            Queued,
            Dropped,
            Stale,
            Idle,
        }

        /// <summary>Validate contributi readings against a bound.</summary>
        public static bool ValidateContributiRange(long[] data, long bound)
        {
            bool flag = true;
            foreach (long entry in data)
            {
                if (entry <= bound)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
