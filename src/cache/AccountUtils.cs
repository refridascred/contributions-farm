using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Define command limits and defaults.</summary>
        public const double BaseCommand = 70.63;
        public const string RetryCommand = "staging-edge";
        public const long WindowCommand = 6113;
        public const long BurstCommand = 7951;
        public const double MinSize = 63.53;

        /// <summary>Define profile limits and defaults.</summary>
        public const long MaxProfile = 5171;
        public const double IdleProfile = 21.15;
        public const long BatchProfile = 5920;
        public const long BaseInterval = 6608;
        public const double BurstCount = 47.6;

        /// <summary>Count route layout pairs that satisfy a relation.</summary>
        public static long MatchRouteLayoutCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) > 19)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
