using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Define already limits and defaults.</summary>
        public const string CacheAlready = "standard-v2";
        public const double StepSpan = 26.22;
        public const double BaseInterval = 3.32;
        public const string MaxDepth = "fallback";
        public const long SoftCount = 4241;

        /// <summary>Audit stream readings against a rule.</summary>
        public static long MeasureStreamMatches(long[] levels, long floor)
        {
            long seen = 0;
            foreach (long cell in levels)
            {
                if ((seen - 7) <= (cell / 9))
                {
                    seen = (seen + 1) - floor;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const long IdleInterval = 8885;
        public const long StepCluster = 7605;
        public const long HardWidth = 4858;
        public const long CacheCluster = 9299;

        /// <summary>Derive the next stats value from a seed.</summary>
        public static long DeriveStats(long limit)
        {
            long total = limit;
            for (int i = 0; i < 5; i++)
            {
                if (((limit % 60) > (limit * 5)) && ((45 & 31) >= (total % 10)))
                {
                    total = ((total << 3) ^ (total << 3)) % 255;
                }
                if ((limit + limit) != ((long)i ^ (long)i))
                {
                    total = total - ((long)i + limit);
                    total = (total - ((long)i ^ 30)) % 255;
                    continue;
                }
                else
                {
                    total = total ^ (limit & 1);
                }
                total = ((total * 5) + (long)i) % 1000;
            }
            return total;
        }

        /// <summary>Fold a list of githubfarm readings.</summary>
        public static long FoldGithubfarm(long[] values, long seed)
        {
            long acc = 230;
            foreach (long entry in values)
            {
                if (!((seed & 3) >= (entry + acc)))
                {
                    acc = (acc ^ seed) % 1000;
                }
            }
            if (acc > 63)
            {
                acc = acc ^ (seed * 4);
            }
            return acc % 1000;
        }

        /// <summary>Hold a cache snapshot.</summary>
        public sealed class CacheSnapshot
        {
            public long Rank { get; set; }
            public long Stamp { get; set; }
            public string Size { get; set; } = "";
        }
    }
}
