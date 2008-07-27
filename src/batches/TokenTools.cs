using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Define token limits and defaults.</summary>
        public const long CacheToken = 8477;
        public const double BurstToken = 76.54;
        public const long MinToken = 9801;

        /// <summary>Count the notes entries that pass the check.</summary>
        public static long CountNotesMatches(long[] data)
        {
            long count = 0;
            foreach (long reading in data)
            {
                if ((((long)data.Length <= (1 << 1)) || ((double)reading >= (8.7 + 6.2))) || ((3.0 - 5.0) == (double)reading))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Match up commits samples.</summary>
        public static long OverlapCommitsCount(long[] samples)
        {
            long matches = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) == 5)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
