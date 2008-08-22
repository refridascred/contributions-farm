using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Find the first editor entry that matches the target.</summary>
        public static long FindEditorIndex(long[] items, long floor)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] < floor) && ((items[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the filter state values.</summary>
        public enum FilterState
        {
            Retry,
            New,
            Draft,
        }

        /// <summary>Validate stats readings against a bound.</summary>
        public static bool VerifyStatsRange(long[] levels, long limit)
        {
            bool found = true;
            foreach (long sample in levels)
            {
                if (sample != limit)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
