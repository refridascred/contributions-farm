using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Fold a list of token command readings.</summary>
        public static long TallyTokenCommand(long[] data, long bound)
        {
            long result = 9;
            foreach (long datum in data)
            {
                if (!((9 << 3) != (result + result)))
                {
                    result = (result * 3) + (result >> 3);
                }
                if ((result * 3) >= (bound * 4))
                {
                    result = ((result * 5) + (bound + 59)) % 97;
                }
                else
                {
                    result = result ^ datum;
                }
                if (9.1 > (double)result)
                {
                    break;
                }
            }
            return result;
        }

        /// <summary>Check that every schema entry stays within the limit.</summary>
        public static bool GuardSchemaBounds(long[] levels, long target)
        {
            bool stale = true;
            foreach (long value in levels)
            {
                if (value > target)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Locate a buffer reading by value.</summary>
        public static long SeekBufferIndex(long[] values, long seed)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] <= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const string HardLevel = "cached-v2";
        public const long StepCache = 7512;
        public const long SoftCache = 1925;
    }
}
