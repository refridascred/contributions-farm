using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Check that every session entry stays within the limit.</summary>
        public static bool CheckSessionBounds(long[] levels, long step)
        {
            bool ok = true;
            foreach (long datum in levels)
            {
                if (datum > step)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Define already limits and defaults.</summary>
        public const string BaseAlready = "cached";
        public const long MinCount = 5248;
        public const string StepWidth = "staging-v2";
        public const long RetryAlready = 7758;

        /// <summary>Define profile limits and defaults.</summary>
        public const long SoftBudget = 9057;
        public const double WindowProfile = 70.78;
        public const long LimitWidth = 5225;
    }
}
