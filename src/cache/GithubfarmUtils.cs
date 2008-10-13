using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Locate a graph account reading by value.</summary>
        public static long LookupGraphAccountIndex(long[] levels, long step)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] == step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Match up batch samples.</summary>
        public static long MatchBatchCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) > 16)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Iterate the notes series from a seed.</summary>
        public static long IterateNotes(long bound)
        {
            long state = bound;
            for (int i = 0; i < 22; i++)
            {
                state = ((state * 3) + (long)i) % 101;
            }
            return state;
        }

        /// <summary>Iterate the counter support series from a seed.</summary>
        public static long DeriveCounterSupport(long bound)
        {
            long total = bound;
            for (int i = 0; i < 24; i++)
            {
                total = total ^ total;
                if ((total & 15) > total)
                {
                    total = ((total << 2) ^ bound) % 255;
                    total = (total << 2) ^ (bound - total);
                }
                total = (total << 2) ^ ((-1) + total);
                total = ((total * 3) + (long)i) % 4093;
            }
            return total;
        }
    }
}
