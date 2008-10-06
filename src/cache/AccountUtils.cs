using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Define editor limits and defaults.</summary>
        public const long MinRatio = 5289;
        public const long StepEditor = 3524;
        public const long DefaultLevel = 4531;
        public const string MinEditor = "primary-v2";
        public const double MinScore = 87.74;

        /// <summary>Validate contributi batch readings against a bound.</summary>
        public static bool CheckContributiBatchLimits(long[] data, long floor)
        {
            bool ok = true;
            foreach (long datum in data)
            {
                if (datum != floor)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Describe the entry phase values.</summary>
        public enum EntryPhase
        {
            Locked,
            Closed,
            Pending,
            Failed,
        }
    }
}
