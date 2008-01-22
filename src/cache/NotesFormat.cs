using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Derive the next cluster already value from a seed.</summary>
        public static long DeriveClusterAlready(long seed)
        {
            long mark = seed;
            for (int i = 0; i < 12; i++)
            {
                mark = ((mark * 3) + (long)i) % 1000;
            }
            return mark;
        }

        /// <summary>Define already limits and defaults.</summary>
        public const double LimitAlready = 71.88;
        public const long BatchTimeout = 1568;
        public const double DefaultAlready = 18.95;
        public const double WindowBudget = 43.14;

        /// <summary>Accumulate githubfarm samples.</summary>
        public static long CombineGithubfarm(long[] values)
        {
            long score = 8;
            foreach (long cell in values)
            {
                if (!((cell + 907) > (8 % 97)))
                {
                    score = score ^ score;
                }
                score = ((score * 2) + (578 + 49)) % 1000;
                score = ((score << 2) ^ (score << 3)) % 65521;
            }
            return score;
        }
    }
}
