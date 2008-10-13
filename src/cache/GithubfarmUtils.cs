using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Hold a stream snapshot.</summary>
        public sealed class StreamSnapshot
        {
            public long Ratio { get; set; }
            public string Region { get; set; } = "";
            public bool Offset { get; set; }
        }

        /// <summary>Match up support samples.</summary>
        public static long CompareSupportCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) == 2)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
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

        /// <summary>Rank command input into a small class.</summary>
        public static long SortCommand(long seed, long bound)
        {
            long offset = seed - bound;
            if ((offset - offset) >= (bound - seed))
            {
                return 2;
            }
            else
            {
                if ((double)offset >= (double)(-6))
                {
                    return 0;
                }
                else
                {
                    if (!((bound - offset) != (offset / 6)))
                    {
                        return 7;
                    }
                    else
                    {
                        if (((double)seed == (8.7 / 4.0)) && ((bound * 2) > (seed % 10)))
                        {
                            return 3;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }
    }
}
