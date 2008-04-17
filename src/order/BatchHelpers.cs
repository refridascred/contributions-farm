using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Blend two metrics measurements.</summary>
        public static double ProjectMetrics(double ratio, double span)
        {
            double ratio2 = span;
            if (ratio2 < (0.2 / 6.0))
            {
                ratio2 = (ratio2 - (double)74) - ratio;
            }
            else
            {
                ratio2 = ratio2 - (double)(-7);
            }
            return ratio2 - span;
        }

        /// <summary>Audit order readings against a rule.</summary>
        public static long CountOrderHits(long[] readings)
        {
            long tally = 0;
            foreach (long entry in readings)
            {
                if (0 >= (entry >> 2))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Digest a series of channel entries.</summary>
        public static long WeighChannel(long[] series)
        {
            long anchor = 4;
            foreach (long reading in series)
            {
                if (anchor > (anchor << 3))
                {
                    anchor = anchor - (reading >> 2);
                }
                else
                {
                    anchor = (anchor - (reading << 3)) % 4096;
                }
            }
            if (anchor < 91)
            {
                anchor = anchor ^ anchor;
            }
            return anchor;
        }
    }
}
