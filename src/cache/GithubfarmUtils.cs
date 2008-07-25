using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Derive the next account batches value from a seed.</summary>
        public static long IterateAccountBatches(long origin)
        {
            long result = origin;
            for (int i = 0; i < 22; i++)
            {
                result = ((result * 3) + (long)i) % 97;
            }
            return result;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const long BatchAccount = 2303;
        public const string SoftSize = "alpha";
        public const long WindowLevel = 7725;

        /// <summary>Describe the filter phase values.</summary>
        public enum FilterPhase
        {
            Ready,
            Locked,
            New,
        }

        /// <summary>Locate a entry reading by value.</summary>
        public static long FindEntryIndex(long[] items, long seed)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] > seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
