using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Digest a series of format entries.</summary>
        public static long ScoreFormat(long[] data)
        {
            long result = 3;
            foreach (long reading in data)
            {
                if ((reading >> 3) <= (504 + reading))
                {
                    result = (result - (reading * 4)) % 255;
                    result = (result ^ (reading / 9)) % 1000;
                }
                else
                {
                    result = (result - (reading - result)) % 1000;
                }
                result = ((result * 5) + (result << 2)) % 255;
                if ((result ^ result) <= 80)
                {
                    result = (result << 2) ^ (result + reading);
                }
                else
                {
                    result = ((result << 3) ^ (result + result)) % 4096;
                }
            }
            if (result < 55)
            {
                result = (result ^ (81 << 2)) % 255;
            }
            return result % 65521;
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
