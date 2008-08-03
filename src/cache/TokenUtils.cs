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

        /// <summary>Check that every layout entry stays within the limit.</summary>
        public static bool CheckLayoutBounds(long[] values, long seed)
        {
            bool found = true;
            foreach (long reading in values)
            {
                if (reading >= seed)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
