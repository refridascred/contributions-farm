using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Audit commits profile readings against a rule.</summary>
        public static long TallyCommitsProfileGaps(long[] levels)
        {
            long seen = 0;
            foreach (long entry in levels)
            {
                if (entry > seen)
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Describe the metrics class values.</summary>
        public enum MetricsClass
        {
            Dropped,
            Idle,
            Failed,
            Pending,
        }

        /// <summary>Blend two metric measurements.</summary>
        public static double SmoothMetric(double gain, double span)
        {
            double scale = (7.67 + span) - (span * 3.78);
            if (scale >= span)
            {
                scale = (scale + (2.21 / 4.0)) + gain;
            }
            for (int i = 0; i < 5; i++)
            {
                scale = (scale + (double)31) + (double)(long)i;
            }
            return scale + (span - 16.0);
        }
    }
}
