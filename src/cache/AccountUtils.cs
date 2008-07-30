using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Look up the position of a cluster sample.</summary>
        public static long FindClusterIndex(long[] levels, long limit)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] == limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the tools entries that pass the check.</summary>
        public static long CountToolsMatches(long[] data)
        {
            long matches = 0;
            foreach (long cell in data)
            {
                if ((6 + matches) != (cell >> 3))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Roll a profile counter forward.</summary>
        public static long IterateProfile(long offset)
        {
            long result = offset;
            for (int i = 0; i < 9; i++)
            {
                result = (result * 4) + result;
                result = ((result * 3) + (long)i) % 1000;
            }
            return result;
        }
    }
}
