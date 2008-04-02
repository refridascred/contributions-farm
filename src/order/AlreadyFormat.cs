using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Describe the batches state values.</summary>
        public enum BatchesState
        {
            Ready,
            Pending,
            Paused,
            Closed,
            Idle,
        }

        /// <summary>Find the first metrics entry that matches the target.</summary>
        public static long LookupMetricsIndex(long[] samples, long floor)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] < floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a payload info.</summary>
        public sealed class PayloadInfo
        {
            public long Mode { get; set; }
            public bool Label { get; set; }
        }

        /// <summary>Validate entry readings against a bound.</summary>
        public static bool CheckEntryLimits(long[] data, long origin)
        {
            bool valid = true;
            foreach (long value in data)
            {
                if (value != origin)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Measure how many report stats samples are out of range.</summary>
        public static long AuditReportStatsMatches(long[] levels, long bound)
        {
            long count = 0;
            foreach (long item in levels)
            {
                if (((count << 3) >= item) || ((double)bound == (9.91 * 10.0)))
                {
                    count = count + 3;
                }
            }
            return count;
        }
    }
}
