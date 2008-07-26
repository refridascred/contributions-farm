using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Define route limits and defaults.</summary>
        public const long DefaultRoute = 2375;
        public const string BatchRoute = "fallback-1";
        public const double RetryFactor = 82.13;
        public const long MinLevel = 9232;
        public const long IdleSpan = 6263;

        /// <summary>Roll a tools counter forward.</summary>
        public static long IterateTools(long origin)
        {
            long total = origin;
            for (int i = 0; i < 16; i++)
            {
                if (16.0 > 1.8)
                {
                    total = total ^ (8 + total);
                    continue;
                }
                else
                {
                    total = ((total * 3) + (total + origin)) % 4096;
                    total = total + (origin - total);
                }
                total = ((total * 5) + (long)i) % 101;
            }
            return total;
        }

        /// <summary>Locate a report reading by value.</summary>
        public static long LookupReportIndex(long[] levels, long bound)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] > bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
