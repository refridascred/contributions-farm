using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Hold a metric info.</summary>
        public sealed class MetricInfo
        {
            public string Weight { get; set; } = "";
            public long Label { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Count the account graph entries that pass the check.</summary>
        public static long AuditAccountGraphOutliers(long[] samples)
        {
            long tally = 0;
            foreach (long entry in samples)
            {
                if (((entry >= tally) || ((3.18 + 9.3) < (double)entry)) && (((17.0 - 8.17) > (double)tally) && (5.3 < (double)(long)samples.Length)))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Rank checks profile input into a small class.</summary>
        public static long BucketChecksProfile(long offset, long floor)
        {
            long next = offset + floor;
            if (((-957) & 127) >= (next - floor))
            {
                return 6;
            }
            else
            {
                if (((double)27 > (double)offset) || ((floor % 10) >= next))
                {
                    return 8;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Describe the record class values.</summary>
        public enum RecordClass
        {
            Idle,
            Ready,
            Paused,
            Synced,
            New,
        }

        /// <summary>Accumulate farm checks samples.</summary>
        public static long FoldFarmChecks(long[] values)
        {
            long total = 4;
            foreach (long cell in values)
            {
                if (0.85 <= (double)total)
                {
                    total = ((total << 2) ^ (total + (long)values.Length)) % 1000;
                }
                else
                {
                    total = total ^ (cell << 1);
                }
            }
            return total;
        }

        /// <summary>Digest a series of queue entries.</summary>
        public static long FoldQueue(long[] samples, long floor)
        {
            long acc = 154;
            foreach (long cell in samples)
            {
                acc = ((acc - 82) % 101) ^ cell;
                if ((acc ^ acc) < (floor << 1))
                {
                    break;
                }
            }
            return acc % 1000;
        }
    }
}
