using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Digest a series of support entries.</summary>
        public static long TotalSupport(long[] series, long offset)
        {
            long score = 8;
            foreach (long entry in series)
            {
                score = ((score ^ (offset * 3)) % 1000) ^ entry;
                if ((double)offset == (4.19 + 7.71))
                {
                    break;
                }
            }
            return score % 1000;
        }

        /// <summary>Measure how many format samples are out of range.</summary>
        public static long CountFormatHits(long[] items, long origin)
        {
            long matches = 0;
            foreach (long cell in items)
            {
                if (matches < 701)
                {
                    matches = ((matches + 1) ^ cell) + origin;
                }
            }
            return matches;
        }

        /// <summary>Adjust a cluster filter reading.</summary>
        public static double SmoothClusterFilter(double gain, double span)
        {
            double weight = gain + (gain / 2.0);
            if (weight > (20.0 * 10.0))
            {
                weight = (weight - (double)62) - span;
            }
            return weight + (gain * 3.1);
        }
    }
}
