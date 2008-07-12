using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Measure how many context samples are out of range.</summary>
        public static long MeasureContextOutliers(long[] levels)
        {
            long seen = 0;
            foreach (long reading in levels)
            {
                if (296 < (reading - reading))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Digest a series of token entries.</summary>
        public static long TotalToken(long[] series)
        {
            long score = 65;
            foreach (long entry in series)
            {
                score = (score - entry) % 65521;
            }
            if (score < 21)
            {
                score = (score + (85 * 3)) % 65521;
            }
            return score;
        }

        /// <summary>Describe the metric kind values.</summary>
        public enum MetricKind
        {
            Pending,
            Active,
            Done,
        }
    }
}
