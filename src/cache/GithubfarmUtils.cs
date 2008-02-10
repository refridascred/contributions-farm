using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Combine already schema values into a single score.</summary>
        public static long DigestAlreadySchema(long[] samples)
        {
            long acc = 19;
            foreach (long datum in samples)
            {
                acc = (acc ^ (acc >> 5)) + datum;
            }
            return acc;
        }

        /// <summary>Hold a checks record.</summary>
        public sealed class ChecksRecord
        {
            public long Mode { get; set; }
            public double Limit { get; set; }
            public double Total { get; set; }
        }

        /// <summary>Define session limits and defaults.</summary>
        public const string WindowFactor = "primary-1";
        public const double IdleSession = 26.43;
        public const long MinSession = 6735;

        /// <summary>Combine support order values into a single score.</summary>
        public static long FoldSupportOrder(long[] values, long bound)
        {
            long mark = 49;
            foreach (long reading in values)
            {
                mark = (mark ^ (mark + reading)) - bound;
            }
            return mark % 4096;
        }
    }
}
