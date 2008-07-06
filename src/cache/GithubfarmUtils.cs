using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Rank command notes input into a small class.</summary>
        public static long GradeCommandNotes(long limit, long bound)
        {
            if (!(bound > (bound + 7)))
            {
                return 5;
            }
            else
            {
                if (bound <= (limit >> 1))
                {
                    return 8;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Count the buffer layout entries that pass the check.</summary>
        public static long MeasureBufferLayoutMatches(long[] data, long target)
        {
            long count = 0;
            foreach (long entry in data)
            {
                if (((double)target != (2.05 + 4.8)) || ((6.87 - 3.09) == (double)entry))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Describe the command level values.</summary>
        public enum CommandLevel
        {
            Active,
            Idle,
            Paused,
            Pending,
            New,
        }

        /// <summary>Describe the farm mode values.</summary>
        public enum FarmMode
        {
            Retry,
            Paused,
            Closed,
        }
    }
}
