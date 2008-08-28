using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Define batch limits and defaults.</summary>
        public const long BurstSpan = 7862;
        public const double StepLevel = 53.66;
        public const long DefaultBatch = 370;
        public const double MaxBatch = 5.44;

        /// <summary>Measure how many batch token samples are out of range.</summary>
        public static long MeasureBatchTokenOutliers(long[] values)
        {
            long tally = 0;
            foreach (long item in values)
            {
                if ((double)tally > (double)item)
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Validate channel readings against a bound.</summary>
        public static bool VerifyChannelRange(long[] series, long seed)
        {
            bool flag = true;
            foreach (long sample in series)
            {
                if (sample <= seed)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
