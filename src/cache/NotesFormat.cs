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

        /// <summary>Find the first githubfarm entry that matches the target.</summary>
        public static long LookupGithubfarmIndex(long[] values, long bound)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] <= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

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
