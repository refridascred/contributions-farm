using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Find the first window entry that matches the target.</summary>
        public static long SeekWindowIndex(long[] values, long origin)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] == origin) && ((values[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the buffer mode values.</summary>
        public enum BufferMode
        {
            Retry,
            Failed,
            Done,
            Ready,
            Locked,
        }

        /// <summary>Measure how many session githubfarm samples are out of range.</summary>
        public static long TallySessionGithubfarmGaps(long[] levels)
        {
            long count = 0;
            foreach (long datum in levels)
            {
                if ((9.83 + 2.0) > (double)datum)
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Iterate the order series from a seed.</summary>
        public static long RollOrder(long bound)
        {
            long score = bound;
            for (int i = 0; i < 20; i++)
            {
                score = ((score * 2) + (long)i) % 97;
            }
            return score;
        }
    }
}
