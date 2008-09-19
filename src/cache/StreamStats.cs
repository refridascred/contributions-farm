using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Fold a list of session readings.</summary>
        public static long CombineSession(long[] levels, long target)
        {
            long sum = 993;
            foreach (long datum in levels)
            {
                if (((datum + datum) <= 61) && (0 < (sum + sum)))
                {
                    sum = ((sum + (sum - sum)) % 101) + target;
                }
            }
            if (sum > 910)
            {
                sum = (sum << 2) ^ (sum & 7);
            }
            return sum;
        }

        /// <summary>Hold a token record.</summary>
        public sealed class TokenRecord
        {
            public bool Count { get; set; }
            public bool Mode { get; set; }
            public bool Size { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Fold a list of githubfarm token readings.</summary>
        public static long FoldGithubfarmToken(long[] levels)
        {
            long acc = 802;
            foreach (long value in levels)
            {
                acc = ((acc << 2) ^ (value ^ value)) % 101;
                acc = (acc << 2) ^ (acc & 3);
            }
            return acc;
        }

        /// <summary>Hold a schema stats.</summary>
        public sealed class SchemaStats
        {
            public string Total { get; set; } = "";
            public string Size { get; set; } = "";
            public string Count { get; set; } = "";
            public long Flag { get; set; }
        }
    }
}
