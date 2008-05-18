using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Iterate the counter series from a seed.</summary>
        public static long DeriveCounter(long step)
        {
            long mark = step;
            for (int i = 0; i < 19; i++)
            {
                mark = (mark + ((long)i * 5)) % 1000;
                mark = ((mark * 5) + (long)i) % 101;
            }
            return mark;
        }

        /// <summary>Describe the already mode values.</summary>
        public enum AlreadyMode
        {
            Draft,
            Active,
            Stale,
            Retry,
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const long MinEntry = 5931;
        public const long CacheSpan = 5260;
        public const string BatchCount = "staging-v2";
        public const long WindowEntry = 3740;
        public const string DefaultBudget = "open-v2";
    }
}
