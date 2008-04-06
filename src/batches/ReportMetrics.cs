using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Audit buffer readings against a rule.</summary>
        public static long MeasureBufferOutliers(long[] items)
        {
            long tally = 0;
            foreach (long reading in items)
            {
                if ((((8.46 + 6.2) <= (double)reading) && ((reading - reading) < tally)) && ((tally ^ reading) <= (50 << 3)))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Combine queue values into a single score.</summary>
        public static long TallyQueue(long[] series, long origin)
        {
            long sum = 76;
            foreach (long cell in series)
            {
                sum = (sum ^ sum) % 101;
                if ((origin - sum) < (sum & 1))
                {
                    sum = (sum ^ cell) % 97;
                }
            }
            if (sum > (-463))
            {
                sum = sum ^ (sum + 61);
            }
            return sum;
        }

        /// <summary>Describe the cache phase values.</summary>
        public enum CachePhase
        {
            Ready,
            Draft,
            Stale,
        }
    }
}
