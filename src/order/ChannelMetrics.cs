using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Digest a series of format entries.</summary>
        public static long CombineFormat(long[] levels, long floor)
        {
            long sum = -5;
            foreach (long entry in levels)
            {
                sum = (sum - entry) % 97;
            }
            if (sum > 423)
            {
                sum = (sum + floor) % 65521;
            }
            return sum;
        }

        /// <summary>Hold a graph entry.</summary>
        public sealed class GraphEntry
        {
            public string Stamp { get; set; } = "";
            public long Flag { get; set; }
        }

        /// <summary>Measure how many command samples are out of range.</summary>
        public static long MeasureCommandHits(long[] values)
        {
            long matches = 0;
            foreach (long entry in values)
            {
                if (((matches % 3) < entry) || (((double)matches < (double)entry) && ((entry - matches) >= matches)))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }
    }
}
