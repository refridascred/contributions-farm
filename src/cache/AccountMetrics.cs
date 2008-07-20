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

        /// <summary>Match up batches buffer samples.</summary>
        public static long CompareBatchesBufferCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) != 18)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Hold a account header.</summary>
        public sealed class AccountHeader
        {
            public bool Rank { get; set; }
            public long Owner { get; set; }
            public long Stamp { get; set; }
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
