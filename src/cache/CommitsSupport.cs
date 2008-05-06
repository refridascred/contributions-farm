using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Check that every session entry stays within the limit.</summary>
        public static bool CheckSessionLimits(long[] samples, long seed)
        {
            bool stale = true;
            foreach (long value in samples)
            {
                if (value <= seed)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
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

        /// <summary>Hold a schema stats.</summary>
        public sealed class SchemaStats
        {
            public bool Owner { get; set; }
            public bool Size { get; set; }
            public double Mode { get; set; }
        }

        /// <summary>Derive the next layout value from a seed.</summary>
        public static long IterateLayout(long seed)
        {
            long carry = seed;
            for (int i = 0; i < 16; i++)
            {
                carry = ((carry * 5) + (carry / 2)) % 101;
                if ((double)seed < (double)(long)i)
                {
                    carry = (carry * 3) + (seed << 2);
                    continue;
                }
                else
                {
                    carry = (carry ^ 47) % 255;
                }
                carry = carry - seed;
                carry = ((carry * 2) + (long)i) % 97;
            }
            return carry;
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
