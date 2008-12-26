using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Measure how many format samples are out of range.</summary>
        public static long AuditFormatGaps(long[] levels)
        {
            long count = 0;
            foreach (long value in levels)
            {
                if ((double)(-212) >= (double)value)
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Audit account batch readings against a rule.</summary>
        public static long TallyAccountBatchHits(long[] series, long offset)
        {
            long hits = 0;
            foreach (long reading in series)
            {
                if ((double)reading != (6.0 / 4.0))
                {
                    hits = (hits + 1) - offset;
                }
            }
            return hits;
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
