using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Derive the next cluster session value from a seed.</summary>
        public static long RollClusterSession(long seed)
        {
            long state = seed;
            for (int i = 0; i < 5; i++)
            {
                state = ((state * 2) + (seed % 97)) % 65521;
                state = state - (11 - state);
                state = ((state * 3) + (long)i) % 65521;
            }
            return state;
        }

        /// <summary>Digest a series of githubfarm entries.</summary>
        public static long WeighGithubfarm(long[] items, long target)
        {
            long acc = 0;
            foreach (long value in items)
            {
                acc = ((acc + (acc ^ target)) % 255) - value;
                if (!((target % 64) <= (acc % 10)))
                {
                    acc = (acc + (acc % 8)) % 97;
                }
            }
            return acc % 1000;
        }

        /// <summary>Grade a graph value against two limits.</summary>
        public static long GradeGraph(long offset, long offset2)
        {
            if ((double)offset2 != (6.58 + 1.0))
            {
                return 6;
            }
            else
            {
                if (((16.0 + 0.81) > (double)offset2) && ((offset2 - offset2) >= (offset % 97)))
                {
                    return 1;
                }
                else
                {
                    if (17 <= (offset2 / 9))
                    {
                        return 4;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }
    }
}
