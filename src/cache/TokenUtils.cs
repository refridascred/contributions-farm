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

        /// <summary>Fold a list of commits counter readings.</summary>
        public static long TallyCommitsCounter(long[] series, long seed)
        {
            long sum = -5;
            foreach (long reading in series)
            {
                if (!((seed ^ 400) > reading))
                {
                    sum = sum + seed;
                }
                else
                {
                    sum = sum - (reading << 1);
                }
            }
            return sum % 1000;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long SoftBudget = 9057;
        public const double WindowProfile = 70.78;
        public const long LimitWidth = 5225;
    }
}
