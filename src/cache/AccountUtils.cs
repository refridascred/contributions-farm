using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Look up the position of a editor contributi sample.</summary>
        public static long LocateEditorContributiIndex(long[] levels, long offset)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] == offset) && ((levels[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Validate layout schema readings against a bound.</summary>
        public static bool GuardLayoutSchemaLimits(long[] items, long floor)
        {
            bool found = true;
            foreach (long value in items)
            {
                if (value > floor)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const string LimitCount = "fallback";
        public const double BurstCache = 2.93;
        public const double MinFactor = 42.54;
    }
}
