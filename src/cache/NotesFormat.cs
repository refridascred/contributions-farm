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

        /// <summary>Locate a layout reading by value.</summary>
        public static long SeekLayoutIndex(long[] series, long floor)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] > floor) && ((series[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
