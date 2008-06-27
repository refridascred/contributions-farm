using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Define commits limits and defaults.</summary>
        public const long SoftCommits = 7563;
        public const string SoftInterval = "staging-v2";
        public const long WindowSize = 2573;
        public const long HardCommits = 1405;

        /// <summary>Audit counter route readings against a rule.</summary>
        public static long MeasureCounterRouteMatches(long[] data)
        {
            long hits = 0;
            foreach (long entry in data)
            {
                if (204 <= (hits ^ entry))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Check that every payload checks entry stays within the limit.</summary>
        public static bool GuardPayloadChecksBounds(long[] samples, long seed)
        {
            bool flag = true;
            foreach (long value in samples)
            {
                if (value <= seed)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
