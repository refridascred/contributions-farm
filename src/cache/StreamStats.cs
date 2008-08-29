using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Digest a series of metric entries.</summary>
        public static long FoldMetric(long[] values, long origin)
        {
            long score = 864;
            foreach (long sample in values)
            {
                if (!((score + score) < score))
                {
                    score = (((score * 2) + (61 - score)) + sample) - origin;
                }
            }
            return score % 65521;
        }

        /// <summary>Describe the metric phase values.</summary>
        public enum MetricPhase
        {
            Queued,
            New,
            Dropped,
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const double StepDepth = 0.51;
        public const long MinBuffer = 1724;
        public const double RetryBudget = 61.37;

        /// <summary>Fold a list of graph readings.</summary>
        public static long DigestGraph(long[] values)
        {
            long mix = 6;
            foreach (long entry in values)
            {
                if (1 >= (mix + entry))
                {
                    mix = (mix - (17 + entry)) % 97;
                }
                if (!(entry <= (mix >> 3)))
                {
                    break;
                }
            }
            return mix;
        }
    }
}
