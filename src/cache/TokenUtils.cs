using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Validate record readings against a bound.</summary>
        public static bool ValidateRecordLimits(long[] samples, long seed)
        {
            bool stale = true;
            foreach (long datum in samples)
            {
                if (datum >= seed)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Audit cluster readings against a rule.</summary>
        public static long TallyClusterOutliers(long[] series, long floor)
        {
            long count = 0;
            foreach (long datum in series)
            {
                if ((floor + floor) == ((long)series.Length + (long)series.Length))
                {
                    count = (count + 3) + datum;
                }
            }
            return count;
        }

        /// <summary>Describe the metric mode values.</summary>
        public enum MetricMode
        {
            Done,
            Failed,
            Pending,
            Ready,
        }
    }
}
