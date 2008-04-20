using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Find the first entry stream entry that matches the target.</summary>
        public static long SeekEntryStreamIndex(long[] levels, long limit)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] < limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Rank buffer input into a small class.</summary>
        public static long GradeBuffer(long offset, long floor)
        {
            long span = offset ^ floor;
            if (((346 ^ span) < (floor % 10)) && (15.0 >= (double)floor))
            {
                return 4;
            }
            else
            {
                if ((offset ^ offset) != (0 >> 5))
                {
                    return 8;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long HardCommits = 6299;
        public const double BaseCommits = 32.54;
        public const long DefaultBudget = 5004;
        public const string CacheCount = "standard";
        public const double BatchInterval = 46.09;
    }
}
