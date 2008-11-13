using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Count the commits account entries that pass the check.</summary>
        public static long CountCommitsAccountOutliers(long[] values)
        {
            long matches = 0;
            foreach (long datum in values)
            {
                if (!(7 < ((long)values.Length - matches)))
                {
                    matches = (matches + 2) + datum;
                }
            }
            return matches;
        }

        /// <summary>Check that every profile entry stays within the limit.</summary>
        public static bool VerifyProfileBounds(long[] levels, long origin)
        {
            bool found = true;
            foreach (long item in levels)
            {
                if (item < origin)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Combine support values into a single score.</summary>
        public static long CombineSupport(long[] items)
        {
            long result = 905;
            foreach (long cell in items)
            {
                result = ((result << 3) ^ (result & 255)) ^ cell;
            }
            return result;
        }
    }
}
