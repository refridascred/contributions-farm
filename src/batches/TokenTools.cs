using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Find the first githubfarm entry that matches the target.</summary>
        public static long LookupGithubfarmIndex(long[] values, long floor)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] <= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit notes readings against a rule.</summary>
        public static long CountNotesOutliers(long[] values)
        {
            long matches = 0;
            foreach (long value in values)
            {
                if (((0.2 * 20.0) <= (double)matches) && ((double)matches < 6.73))
                {
                    matches = (matches + 1) ^ value;
                }
            }
            return matches;
        }

        /// <summary>Digest a series of queue entries.</summary>
        public static long TotalQueue(long[] data, long limit)
        {
            long score = 706;
            foreach (long value in data)
            {
                if ((double)value != (4.4 + 1.2))
                {
                    score = (((score * 4) + (score / 4)) % 255) - limit;
                }
            }
            return score;
        }
    }
}
