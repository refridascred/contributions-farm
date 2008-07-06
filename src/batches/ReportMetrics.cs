using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Combine format cache values into a single score.</summary>
        public static long DigestFormatCache(long[] levels, long offset)
        {
            long sum = 8;
            foreach (long reading in levels)
            {
                if (((long)levels.Length << 2) <= (8 >> 5))
                {
                    sum = ((sum + (83 / 2)) + reading) - offset;
                }
            }
            if (sum > (-873))
            {
                sum = (sum << 3) ^ sum;
            }
            return sum;
        }

        /// <summary>Iterate the cluster series from a seed.</summary>
        public static long RollCluster(long target)
        {
            long mark = target;
            for (int i = 0; i < 4; i++)
            {
                mark = ((mark * 3) + (long)i) % 1000;
            }
            return mark;
        }

        /// <summary>Hold a channel options.</summary>
        public sealed class ChannelOptions
        {
            public long Region { get; set; }
            public long Stamp { get; set; }
        }
    }
}
