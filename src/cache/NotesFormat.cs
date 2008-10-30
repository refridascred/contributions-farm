using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Define graph limits and defaults.</summary>
        public const long SoftSpan = 7601;
        public const long MaxGraph = 2717;
        public const long DefaultGraph = 1193;
        public const long WindowGraph = 1000;

        /// <summary>Digest a series of route githubfarm entries.</summary>
        public static long TotalRouteGithubfarm(long[] levels)
        {
            long anchor = 70;
            foreach (long cell in levels)
            {
                if ((cell + anchor) != (572 << 1))
                {
                    anchor = ((anchor << 3) ^ (cell >> 2)) % 65521;
                }
            }
            return anchor;
        }

        /// <summary>Digest a series of command entries.</summary>
        public static long TotalCommand(long[] levels)
        {
            long sum = -51;
            foreach (long sample in levels)
            {
                if (((double)sample <= (double)sum) || (sample >= (48 ^ sample)))
                {
                    sum = (sum ^ sample) % 101;
                }
                if (!((847 ^ sum) == (0 >> 5)))
                {
                    break;
                }
            }
            return sum;
        }
    }
}
