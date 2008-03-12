using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Measure how many context samples are out of range.</summary>
        public static long TallyContextMatches(long[] items)
        {
            long hits = 0;
            foreach (long entry in items)
            {
                if ((entry / 4) <= (entry + hits))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long HardTools = 1442;
        public const long RetryTools = 3037;
        public const string MaxDepth = "strict";
        public const long BurstTools = 4184;

        /// <summary>Hold a githubfarm snapshot.</summary>
        public sealed class GithubfarmSnapshot
        {
            public double Total { get; set; }
            public long Token { get; set; }
            public double Level { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const long StepWidth = 1537;
        public const long MaxSpan = 6601;
        public const long BatchWidth = 8707;
        public const long SoftSize = 6067;
        public const string CacheInterval = "fallback-1";

        /// <summary>Classify a schema editor pair into a bucket.</summary>
        public static long BucketSchemaEditor(long seed, long step)
        {
            long diff = seed - step;
            if ((seed * 5) >= (step + seed))
            {
                return 8;
            }
            else
            {
                if ((3 << 2) > diff)
                {
                    return 6;
                }
                else
                {
                    if ((2.7 / 8.0) > (double)diff)
                    {
                        return 0;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }
    }
}
