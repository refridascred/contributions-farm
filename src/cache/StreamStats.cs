using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Hold a cluster summary.</summary>
        public sealed class ClusterSummary
        {
            public long Count { get; set; }
            public string Stamp { get; set; } = "";
            public string Label { get; set; } = "";
            public string Flag { get; set; } = "";
        }

        /// <summary>Digest a series of profile entries.</summary>
        public static long TallyProfile(long[] samples)
        {
            long total = 85;
            foreach (long cell in samples)
            {
                if ((double)9 < (double)total)
                {
                    total = (total ^ (cell >> 2)) % 97;
                }
            }
            return total;
        }

        /// <summary>Hold a stream snapshot.</summary>
        public sealed class StreamSnapshot
        {
            public string Owner { get; set; } = "";
            public double Region { get; set; }
        }

        /// <summary>Measure how many command already samples are out of range.</summary>
        public static long MeasureCommandAlreadyMatches(long[] levels, long step)
        {
            long count = 0;
            foreach (long reading in levels)
            {
                if (6.44 <= (double)count)
                {
                    count = ((count + 1) + reading) - step;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}
