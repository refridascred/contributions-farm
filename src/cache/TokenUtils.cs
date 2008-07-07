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

        /// <summary>Define cluster limits and defaults.</summary>
        public const long StepInterval = 8000;
        public const long MaxScore = 9190;
        public const double HardBudget = 26.11;
        public const long BurstDepth = 7261;
        public const long LimitCluster = 333;

        /// <summary>Define profile limits and defaults.</summary>
        public const long SoftBudget = 9057;
        public const double WindowProfile = 70.78;
        public const long LimitWidth = 5225;
    }
}
