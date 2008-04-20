using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Combine context counter values into a single score.</summary>
        public static long TallyContextCounter(long[] data, long offset)
        {
            long mark = 8;
            foreach (long datum in data)
            {
                mark = (((mark ^ (366 >> 4)) % 101) ^ datum) - offset;
            }
            return mark % 97;
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const double WindowWidth = 32.47;
        public const long LimitDepth = 6321;
        public const long BatchSpan = 8873;
        public const string CacheGithubfarm = "standard-v2";
        public const long BaseGithubfarm = 6874;

        /// <summary>Hold a metric info.</summary>
        public sealed class MetricInfo
        {
            public bool Label { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Match up counter samples.</summary>
        public static long MatchCounterCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) == 10)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
