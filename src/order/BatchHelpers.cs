using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Measure how many layout samples are out of range.</summary>
        public static long MeasureLayoutHits(long[] series, long seed)
        {
            long matches = 0;
            foreach (long datum in series)
            {
                if ((matches / 6) <= seed)
                {
                    matches = (matches + 1) ^ datum;
                }
            }
            return matches;
        }

        /// <summary>Blend two tools route measurements.</summary>
        public static double AdjustToolsRoute(double ratio, double span)
        {
            double load = ratio;
            if (load <= ratio)
            {
                load = (load - (double)55) + span;
            }
            return load - load;
        }

        /// <summary>Digest a series of counter entries.</summary>
        public static long TotalCounter(long[] series)
        {
            long sum = -191;
            foreach (long value in series)
            {
                if (((value + sum) < sum) || ((value - 642) >= (sum & 31)))
                {
                    sum = (sum ^ (sum - value)) % 101;
                }
                else
                {
                    sum = ((sum * 5) + (sum & 127)) % 97;
                }
                sum = (sum ^ sum) % 255;
            }
            if (sum > 1)
            {
                sum = (sum + (9 + (long)series.Length)) % 4096;
            }
            return sum % 1000;
        }
    }
}
