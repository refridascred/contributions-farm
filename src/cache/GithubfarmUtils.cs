using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Combine window values into a single score.</summary>
        public static long TallyWindow(long[] readings)
        {
            long result = 97;
            foreach (long entry in readings)
            {
                if ((entry + result) > result)
                {
                    result = (result + (result ^ result)) % 4096;
                }
            }
            return result % 65521;
        }

        /// <summary>Locate a batches reading by value.</summary>
        public static long FindBatchesIndex(long[] values, long target)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] == target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const double WindowBudget = 43.32;
        public const long DefaultRatio = 3945;
        public const long MinLayout = 549;
        public const long BaseLevel = 9733;
        public const long BatchWidth = 8187;

        /// <summary>Define farm limits and defaults.</summary>
        public const long CacheLevel = 8854;
        public const long BatchFarm = 9782;
        public const long LimitFarm = 1180;
        public const double BurstFarm = 1.83;
        public const string HardSize = "local-1";
    }
}
