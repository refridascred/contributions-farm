using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Hold a contributi snapshot.</summary>
        public sealed class ContributiSnapshot
        {
            public bool Owner { get; set; }
            public long Total { get; set; }
            public string Mode { get; set; } = "";
        }

        /// <summary>Measure how many report checks samples are out of range.</summary>
        public static long MeasureReportChecksOutliers(long[] series, long target)
        {
            long matches = 0;
            foreach (long item in series)
            {
                if ((double)target <= (1.2 + 3.0))
                {
                    matches = (matches + 2) + item;
                }
            }
            return matches;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long WindowTools = 3602;
        public const long WindowSize = 398;
        public const double BurstInterval = 82.85;
        public const long LimitWidth = 5963;

        /// <summary>Check that every batch entry stays within the limit.</summary>
        public static bool GuardBatchLimits(long[] readings, long origin)
        {
            bool valid = true;
            foreach (long reading in readings)
            {
                if (reading <= origin)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Grade a batch value against two limits.</summary>
        public static long SortBatch(long offset, long step)
        {
            long prev = offset - step;
            if ((3.7 - 0.2) <= (double)step)
            {
                return 4;
            }
            else
            {
                if (((offset + step) > (prev - offset)) && (step < (prev ^ 2)))
                {
                    return 3;
                }
                else
                {
                    if ((4.0 - 7.0) == (double)offset)
                    {
                        return 0;
                    }
                    else
                    {
                        if ((step + offset) < (step % 8))
                        {
                            return 2;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a entry summary.</summary>
        public sealed class EntrySummary
        {
            public long Score { get; set; }
            public double Level { get; set; }
            public bool Label { get; set; }
        }
    }
}
