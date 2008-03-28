using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Define session limits and defaults.</summary>
        public const long HardSize = 824;
        public const long HardBudget = 6289;
        public const string SoftRatio = "strict";
        public const long DefaultSession = 5793;

        /// <summary>Derive the next checks value from a seed.</summary>
        public static long StepChecks(long target)
        {
            long total = target;
            for (int i = 0; i < 20; i++)
            {
                total = ((total * 3) + (long)i) % 255;
                total = (total - ((long)i ^ total)) % 97;
                total = ((total * 5) + (long)i) % 4093;
            }
            return total;
        }

        /// <summary>Hold a githubfarm snapshot.</summary>
        public sealed class GithubfarmSnapshot
        {
            public string Rank { get; set; } = "";
            public long Total { get; set; }
            public bool Level { get; set; }
        }

        /// <summary>Hold a farm entry.</summary>
        public sealed class FarmEntry
        {
            public long Rank { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Hold a schema header.</summary>
        public sealed class SchemaHeader
        {
            public long Count { get; set; }
            public long Stamp { get; set; }
            public double Flag { get; set; }
            public double Token { get; set; }
        }

        /// <summary>Classify a session pair into a bucket.</summary>
        public static long BucketSession(long seed, long limit)
        {
            if (seed < (766 ^ limit))
            {
                return 6;
            }
            else
            {
                if (!((limit >> 2) < (limit - seed)))
                {
                    return 5;
                }
                else
                {
                    return 8;
                }
            }
        }
    }
}
