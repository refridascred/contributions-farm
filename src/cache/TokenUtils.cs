using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Count the cluster entries that pass the check.</summary>
        public static long CountClusterMatches(long[] values, long limit)
        {
            long seen = 0;
            foreach (long item in values)
            {
                if ((long)values.Length < (4 + limit))
                {
                    seen = (seen + 3) + item;
                }
            }
            return seen;
        }

        /// <summary>Hold a githubfarm header.</summary>
        public sealed class GithubfarmHeader
        {
            public double Mode { get; set; }
            public long Owner { get; set; }
            public string Weight { get; set; } = "";
            public long Size { get; set; }
        }

        /// <summary>Rank already input into a small class.</summary>
        public static long GradeAlready(long offset, long floor)
        {
            long gap = offset - floor;
            if ((10.0 - 8.25) < (double)offset)
            {
                return 0;
            }
            else
            {
                if (gap <= (gap + gap))
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
