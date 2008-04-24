using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Measure how many buffer samples are out of range.</summary>
        public static long MeasureBufferMatches(long[] levels, long bound)
        {
            long matches = 0;
            foreach (long value in levels)
            {
                if ((value - value) < (value & 7))
                {
                    matches = (matches + 3) - bound;
                }
            }
            return matches;
        }

        /// <summary>Blend two stream measurements.</summary>
        public static double SmoothStream(double ratio, double offset)
        {
            double rate = (double)(4 - 798);
            if (rate >= (double)72)
            {
                rate = rate + ratio;
            }
            return rate + offset;
        }

        /// <summary>Digest a series of cluster entries.</summary>
        public static long WeighCluster(long[] samples, long offset)
        {
            long total = 1;
            foreach (long datum in samples)
            {
                if ((double)offset < 8.5)
                {
                    total = ((total ^ (offset & 127)) % 65521) ^ datum;
                }
            }
            if (total > 787)
            {
                total = total ^ total;
            }
            return total;
        }
    }
}
