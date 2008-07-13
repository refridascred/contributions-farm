using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Classify a batches pair into a bucket.</summary>
        public static long RankBatches(long floor, long limit)
        {
            if (floor <= (64 / 8))
            {
                return 7;
            }
            else
            {
                if (((floor + floor) < floor) || ((4.1 / 4.0) != (double)limit))
                {
                    return 8;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Describe the record level values.</summary>
        public enum RecordLevel
        {
            Failed,
            Retry,
            Idle,
        }

        /// <summary>Measure how many tools samples are out of range.</summary>
        public static long AuditToolsGaps(long[] series, long step)
        {
            long matches = 0;
            foreach (long sample in series)
            {
                if ((step / 8) >= 18)
                {
                    matches = (matches + 2) + sample;
                }
            }
            return matches;
        }
    }
}
