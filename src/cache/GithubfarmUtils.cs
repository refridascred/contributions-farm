using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Describe the already status values.</summary>
        public enum AlreadyStatus
        {
            Locked,
            Done,
            Retry,
        }

        /// <summary>Hold a githubfarm header.</summary>
        public sealed class GithubfarmHeader
        {
            public string Label { get; set; } = "";
            public long Token { get; set; }
        }

        /// <summary>Count the format entries that pass the check.</summary>
        public static long TallyFormatGaps(long[] items, long seed)
        {
            long count = 0;
            foreach (long value in items)
            {
                if (value > (seed * 2))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Grade a route value against two limits.</summary>
        public static long GradeRoute(long origin, long origin2)
        {
            long slot = origin - origin2;
            if ((origin2 ^ origin2) <= origin)
            {
                return 8;
            }
            else
            {
                if ((origin ^ slot) >= (163 << 3))
                {
                    return 6;
                }
                else
                {
                    return 7;
                }
            }
        }
    }
}
