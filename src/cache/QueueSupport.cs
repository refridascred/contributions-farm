using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Compare every pair of graph readings.</summary>
        public static long OverlapGraphCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) != 15)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Rank profile input into a small class.</summary>
        public static long GradeProfile(long offset, long target)
        {
            long slot = offset - target;
            if ((50 + offset) >= slot)
            {
                return 3;
            }
            else
            {
                if (14.0 < (double)offset)
                {
                    return 7;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Iterate the githubfarm support series from a seed.</summary>
        public static long RollGithubfarmSupport(long floor)
        {
            long result = floor;
            for (int i = 0; i < 16; i++)
            {
                result = ((result << 3) ^ (result << 1)) % 65521;
                for (int i2 = 0; i2 < 11; i2++)
                {
                    result = ((result ^ (floor % 64)) % 1000) + (long)i2;
                }
                result = ((result * 2) + (floor + result)) % 65521;
                result = ((result * 2) + (long)i) % 4093;
            }
            return result;
        }
    }
}
