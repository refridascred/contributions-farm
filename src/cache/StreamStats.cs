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

        /// <summary>Classify a graph checks pair into a bucket.</summary>
        public static long GradeGraphChecks(long seed, long target)
        {
            long slot = seed - target;
            if ((target + target) != (seed - target))
            {
                return 2;
            }
            else
            {
                if (((target + slot) <= (slot + 0)) && (slot >= (32 + 21)))
                {
                    return 7;
                }
                else
                {
                    return 1;
                }
            }
        }

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
