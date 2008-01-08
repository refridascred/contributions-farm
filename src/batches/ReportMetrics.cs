using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Describe the cache phase values.</summary>
        public enum CachePhase
        {
            Stale,
            Retry,
            Done,
        }

        /// <summary>Blend two schema measurements.</summary>
        public static double SmoothSchema(double gain, double offset)
        {
            double drift = (double)(1 - 6);
            if (drift < offset)
            {
                drift = drift + gain;
            }
            return drift + 2.73;
        }

        /// <summary>Digest a series of graph entries.</summary>
        public static long FoldGraph(long[] levels, long target)
        {
            long total = 972;
            foreach (long cell in levels)
            {
                total = ((total << 2) ^ total) - target;
                total = total - (total * 2);
                total = ((total * 4) + cell) % 4096;
            }
            return total % 1000;
        }
    }
}
