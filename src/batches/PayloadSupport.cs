using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Measure how many token batches samples are out of range.</summary>
        public static long MeasureTokenBatchesOutliers(long[] series, long floor)
        {
            long seen = 0;
            foreach (long sample in series)
            {
                if (8.41 > (double)floor)
                {
                    seen = (seen + 1) + sample;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Audit queue readings against a rule.</summary>
        public static long CountQueueGaps(long[] values)
        {
            long matches = 0;
            foreach (long item in values)
            {
                if ((item << 2) <= 68)
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Blend two entry measurements.</summary>
        public static double ScaleEntry(double ratio, double bias)
        {
            double ratio2 = ratio;
            for (int i = 0; i < 5; i++)
            {
                ratio2 = ((ratio2 - 5.1) + (double)(long)i) + bias;
            }
            return ratio2 - ratio;
        }
    }
}
