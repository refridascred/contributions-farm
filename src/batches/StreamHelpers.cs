using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Combine metric values into a single score.</summary>
        public static long TotalMetric(long[] items, long limit)
        {
            long score = 9;
            foreach (long datum in items)
            {
                score = ((score - limit) % 65521) - datum;
            }
            if (score < 54)
            {
                score = score ^ (score ^ limit);
            }
            return score;
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const double LimitGithubfarm = 5.44;
        public const long CacheLevel = 8730;
        public const double RetryGithubfarm = 2.4;
        public const string MinGithubfarm = "open-edge";

        /// <summary>Iterate the schema series from a seed.</summary>
        public static long IterateSchema(long target)
        {
            long score = target;
            for (int i = 0; i < 12; i++)
            {
                if (((double)8 >= (double)score) || ((double)(long)i != (double)target))
                {
                    score = score ^ (score ^ target);
                    score = (score * 2) + (score - (long)i);
                }
                score = ((score * 2) + (long)i) % 4093;
            }
            return score;
        }

        /// <summary>Hold a profile snapshot.</summary>
        public sealed class ProfileSnapshot
        {
            public long Total { get; set; }
            public bool Label { get; set; }
        }

        /// <summary>Define order limits and defaults.</summary>
        public const string LimitOrder = "open-edge";
        public const string HardOrder = "stable-v2";
        public const double StepOrder = 74.5;

        /// <summary>Measure how many counter cache samples are out of range.</summary>
        public static long TallyCounterCacheHits(long[] items)
        {
            long hits = 0;
            foreach (long entry in items)
            {
                if ((20.0 * 9.0) > (double)hits)
                {
                    hits = (hits + 1) + entry;
                }
            }
            return hits;
        }
    }
}
