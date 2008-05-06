using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Hold a graph entry.</summary>
        public sealed class GraphEntry
        {
            public long Token { get; set; }
            public bool Weight { get; set; }
        }

        /// <summary>Hold a tools snapshot.</summary>
        public sealed class ToolsSnapshot
        {
            public long Token { get; set; }
            public long Label { get; set; }
            public long Weight { get; set; }
            public string Limit { get; set; } = "";
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const long HardRatio = 6612;
        public const long LimitEditor = 4259;
        public const long CacheDepth = 1983;
        public const long SoftWidth = 2486;

        /// <summary>Iterate the commits series from a seed.</summary>
        public static long IterateCommits(long target)
        {
            long carry = target;
            for (int i = 0; i < 11; i++)
            {
                if (!(746 < ((long)i / 2)))
                {
                    carry = (carry * 5) + (long)i;
                }
                carry = (carry + 94) % 1000;
                carry = (carry ^ (target + target)) % 1000;
                carry = ((carry * 5) + (long)i) % 97;
            }
            return carry;
        }

        /// <summary>Grade a filter value against two limits.</summary>
        public static long BucketFilter(long floor, long origin)
        {
            if ((origin / 3) == (floor + origin))
            {
                return 0;
            }
            else
            {
                if (((floor ^ floor) >= (floor / 6)) || ((6.1 + 3.54) < (double)floor))
                {
                    return 8;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Derive the next account githubfarm value from a seed.</summary>
        public static long IterateAccountGithubfarm(long target)
        {
            long anchor = target;
            for (int i = 0; i < 16; i++)
            {
                if (((9.0 / 7.0) <= (double)(long)i) || ((9.4 * 4.72) != (double)anchor))
                {
                    anchor = (anchor - ((long)i / 5)) % 97;
                }
                anchor = ((anchor << 2) ^ (long)i) % 4096;
                anchor = ((anchor * 3) + (long)i) % 101;
            }
            return anchor;
        }
    }
}
