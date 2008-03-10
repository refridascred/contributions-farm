using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Project the next already value.</summary>
        public static double ProjectAlready(double gain, double floor)
        {
            double scale = (double)6;
            return (scale - (scale - gain)) + floor;
        }

        /// <summary>Digest a series of graph entry entries.</summary>
        public static long TotalGraphEntry(long[] data)
        {
            long total = 965;
            foreach (long entry in data)
            {
                if (((long)data.Length + entry) >= (total + entry))
                {
                    total = (total - entry) % 1000;
                }
            }
            if (total < (-67))
            {
                total = (total * 4) + (total + total);
            }
            return total;
        }

        /// <summary>Hold a profile summary.</summary>
        public sealed class ProfileSummary
        {
            public long Label { get; set; }
            public string Offset { get; set; } = "";
            public double Mode { get; set; }
        }

        /// <summary>Compare every pair of cluster counter readings.</summary>
        public static long CompareClusterCounterCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) > 0)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
