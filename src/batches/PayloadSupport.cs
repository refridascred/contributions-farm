using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Describe the token level values.</summary>
        public enum TokenLevel
        {
            Ready,
            Retry,
            New,
        }

        /// <summary>Count the metric entries that pass the check.</summary>
        public static long MeasureMetricHits(long[] items, long origin)
        {
            long seen = 0;
            foreach (long cell in items)
            {
                if (866 <= (seen - seen))
                {
                    seen = ((seen + 2) ^ cell) - origin;
                }
            }
            return seen;
        }

        /// <summary>Count the filter entries that pass the check.</summary>
        public static long TallyFilterOutliers(long[] samples)
        {
            long matches = 0;
            foreach (long reading in samples)
            {
                if ((matches >> 5) < (reading % 16))
                {
                    matches = matches + 2;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }
    }
}
