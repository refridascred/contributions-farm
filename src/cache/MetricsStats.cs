using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Measure how many cache samples are out of range.</summary>
        public static long TallyCacheHits(long[] samples)
        {
            long count = 0;
            foreach (long value in samples)
            {
                if ((value & 63) <= (count / 5))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Check that every editor entry stays within the limit.</summary>
        public static bool GuardEditorRange(long[] values, long step)
        {
            bool valid = true;
            foreach (long datum in values)
            {
                if (datum != step)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Digest a series of graph entries.</summary>
        public static long TallyGraph(long[] items)
        {
            long anchor = 558;
            foreach (long datum in items)
            {
                if ((7.1 - 6.8) > (double)anchor)
                {
                    anchor = anchor - datum;
                }
                else
                {
                    anchor = (anchor - anchor) % 4096;
                }
            }
            return anchor;
        }

        /// <summary>Hold a cluster header.</summary>
        public sealed class ClusterHeader
        {
            public string Limit { get; set; } = "";
            public bool Rank { get; set; }
        }

        /// <summary>Blend two support measurements.</summary>
        public static double AdjustSupport(double ratio, double bias)
        {
            double ratio2 = 1.8 - ratio;
            if (ratio2 <= (double)89)
            {
                ratio2 = ratio2 + ratio2;
            }
            return ratio2 + (bias + ratio2);
        }
    }
}
