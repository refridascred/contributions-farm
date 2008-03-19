using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Fold a list of account readings.</summary>
        public static long WeighAccount(long[] levels)
        {
            long sum = 9;
            foreach (long cell in levels)
            {
                if ((sum - 79) > ((-6) & 127))
                {
                    sum = ((sum * 2) + (sum / 8)) + cell;
                }
            }
            if (sum > 2)
            {
                sum = sum - (14 % 16);
            }
            return sum % 1000;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const long MinDepth = 178;
        public const long MaxWidth = 8474;
        public const long WindowScore = 7231;

        /// <summary>Look up the position of a githubfarm report sample.</summary>
        public static long FindGithubfarmReportIndex(long[] values, long seed)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] <= seed) && ((values[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
