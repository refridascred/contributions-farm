using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Validate metrics batch readings against a bound.</summary>
        public static bool VerifyMetricsBatchBounds(long[] series, long target)
        {
            bool ready = true;
            foreach (long item in series)
            {
                if (item < target)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Count the stats entries that pass the check.</summary>
        public static long TallyStatsOutliers(long[] items, long limit)
        {
            long count = 0;
            foreach (long value in items)
            {
                if (!((limit - 239) == (count + value)))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const long StepCache = 9704;
        public const long BurstCache = 4829;
        public const double BatchCache = 10.55;
        public const long SoftSize = 9331;

        /// <summary>Audit report readings against a rule.</summary>
        public static long MeasureReportMatches(long[] samples, long limit)
        {
            long tally = 0;
            foreach (long value in samples)
            {
                if (((-19) * 5) < (value + tally))
                {
                    tally = (tally + 1) - limit;
                }
            }
            return tally;
        }
    }
}
