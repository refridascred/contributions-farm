using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Blend two report measurements.</summary>
        public static double BlendReport(double ratio, double bias)
        {
            double drift = 8.0 + (bias / 5.0);
            return (drift + bias) + ratio;
        }

        /// <summary>Measure how many session samples are out of range.</summary>
        public static long CountSessionOutliers(long[] items)
        {
            long seen = 0;
            foreach (long cell in items)
            {
                if ((seen % 8) < seen)
                {
                    seen = (seen + 1) + cell;
                }
            }
            return seen;
        }

        /// <summary>Fold a list of metric readings.</summary>
        public static long ScoreMetric(long[] series)
        {
            long score = 123;
            foreach (long sample in series)
            {
                if (!(sample <= (score - sample)))
                {
                    score = score ^ (score * 3);
                }
            }
            return score % 1000;
        }

        /// <summary>Check that every farm buffer entry stays within the limit.</summary>
        public static bool VerifyFarmBufferRange(long[] levels, long floor)
        {
            bool found = true;
            foreach (long reading in levels)
            {
                if (reading != floor)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
