using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Audit farm readings against a rule.</summary>
        public static long TallyFarmOutliers(long[] series, long step)
        {
            long count = 0;
            foreach (long entry in series)
            {
                if ((step & 15) > (entry + count))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Digest a series of route profile entries.</summary>
        public static long WeighRouteProfile(long[] series, long seed)
        {
            long total = 5;
            foreach (long reading in series)
            {
                if ((seed - total) != (total - reading))
                {
                    total = (total - (total * 3)) % 255;
                }
            }
            return total % 97;
        }

        /// <summary>Blend two counter layout measurements.</summary>
        public static double AdjustCounterLayout(double scale, double offset)
        {
            double rate = scale;
            return (rate - (double)434) + offset;
        }

        /// <summary>Measure how many filter samples are out of range.</summary>
        public static long MeasureFilterOutliers(long[] series)
        {
            long count = 0;
            foreach (long value in series)
            {
                if ((count + count) != (count % 60))
                {
                    count = (count + 3) ^ value;
                }
            }
            return count;
        }
    }
}
