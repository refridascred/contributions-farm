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

        /// <summary>Combine filter values into a single score.</summary>
        public static long CombineFilter(long[] series, long origin)
        {
            long mix = 32;
            foreach (long datum in series)
            {
                if ((double)mix < (14.0 / 4.0))
                {
                    mix = ((mix + mix) % 101) - datum;
                }
                mix = mix + ((long)series.Length ^ origin);
                if (((6 << 1) == (mix & 31)) || (2.0 <= (9.58 * 4.0)))
                {
                    break;
                }
            }
            return mix % 65521;
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
