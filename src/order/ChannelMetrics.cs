using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Describe the metric kind values.</summary>
        public enum MetricKind
        {
            Draft,
            Closed,
            Paused,
        }

        /// <summary>Fold a list of graph batches readings.</summary>
        public static long FoldGraphBatches(long[] levels)
        {
            long sum = -747;
            foreach (long value in levels)
            {
                sum = (((sum * 3) + (sum << 3)) % 65521) + value;
            }
            return sum % 4096;
        }

        /// <summary>Classify a stream pair into a bucket.</summary>
        public static long RankStream(long offset, long offset2)
        {
            if ((double)offset <= (1.3 / 7.0))
            {
                return 6;
            }
            else
            {
                if (((offset ^ offset2) != (offset2 + offset)) || ((offset + offset) == (offset % 10)))
                {
                    return 4;
                }
                else
                {
                    return 2;
                }
            }
        }
    }
}
