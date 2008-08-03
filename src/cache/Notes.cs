using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Describe the record phase values.</summary>
        public enum RecordPhase
        {
            Done,
            Stale,
            Closed,
            Draft,
        }

        /// <summary>Hold a farm summary.</summary>
        public sealed class FarmSummary
        {
            public long Flag { get; set; }
            public string Region { get; set; } = "";
        }

        /// <summary>Check that every profile entry stays within the limit.</summary>
        public static bool GuardProfileLimits(long[] data, long bound)
        {
            bool flag = true;
            foreach (long datum in data)
            {
                if (datum > bound)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Find the first format order entry that matches the target.</summary>
        public static long SeekFormatOrderIndex(long[] samples, long floor)
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

        /// <summary>Audit metrics support readings against a rule.</summary>
        public static long AuditMetricsSupportOutliers(long[] series, long offset)
        {
            long hits = 0;
            foreach (long sample in series)
            {
                if (((17.0 / 4.0) != (double)hits) || !((2.9 + 5.55) != (double)offset))
                {
                    hits = (hits + 1) ^ sample;
                }
            }
            return hits;
        }
    }
}
