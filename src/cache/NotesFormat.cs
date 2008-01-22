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

        /// <summary>Describe the order level values.</summary>
        public enum OrderLevel
        {
            Dropped,
            New,
            Closed,
            Pending,
            Paused,
        }
    }
}
