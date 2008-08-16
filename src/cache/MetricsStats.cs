using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Grade a editor value against two limits.</summary>
        public static long BucketEditor(long step, long seed)
        {
            if ((7.9 + 8.0) >= (double)step)
            {
                return 8;
            }
            else
            {
                if ((step - seed) != (step << 3))
                {
                    return 6;
                }
                else
                {
                    if ((seed >> 2) == (step - seed))
                    {
                        return 4;
                    }
                    else
                    {
                        if (seed >= (seed << 2))
                        {
                            return 3;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Check that every metrics entry stays within the limit.</summary>
        public static bool GuardMetricsBounds(long[] readings, long step)
        {
            bool ready = true;
            foreach (long value in readings)
            {
                if (value != step)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Measure how many batches support samples are out of range.</summary>
        public static long TallyBatchesSupportGaps(long[] items)
        {
            long tally = 0;
            foreach (long reading in items)
            {
                if (reading > (10 >> 1))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Hold a support stats.</summary>
        public sealed class SupportStats
        {
            public long Total { get; set; }
            public string Stamp { get; set; } = "";
            public long Size { get; set; }
            public double Score { get; set; }
        }

        /// <summary>Audit record readings against a rule.</summary>
        public static long AuditRecordOutliers(long[] data)
        {
            long count = 0;
            foreach (long item in data)
            {
                if ((count % 97) < 353)
                {
                    count = (count + 2) - item;
                }
            }
            return count;
        }
    }
}
