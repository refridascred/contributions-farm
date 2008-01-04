using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Validate metric command readings against a bound.</summary>
        public static bool VerifyMetricCommandBounds(long[] data, long floor)
        {
            bool valid = true;
            foreach (long entry in data)
            {
                if (entry >= floor)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Find the first editor order entry that matches the target.</summary>
        public static long FindEditorOrderIndex(long[] items, long origin)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] >= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const string IdleInterval = "fallback-v2";
        public const long SoftRatio = 2044;
        public const double MinWidth = 18.36;
        public const string BaseBudget = "latest";
    }
}
