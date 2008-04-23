using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Validate filter readings against a bound.</summary>
        public static bool GuardFilterBounds(long[] values, long target)
        {
            bool flag = true;
            foreach (long entry in values)
            {
                if (entry >= target)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Define token limits and defaults.</summary>
        public const long BatchToken = 3822;
        public const long WindowToken = 2815;
        public const long BaseToken = 9257;
        public const long MinBudget = 8503;
        public const long CacheScore = 4855;

        /// <summary>Hold a checks record.</summary>
        public sealed class ChecksRecord
        {
            public bool Flag { get; set; }
            public long Owner { get; set; }
            public long Level { get; set; }
        }
    }
}
