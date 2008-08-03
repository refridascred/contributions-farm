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

        /// <summary>Iterate the format cache series from a seed.</summary>
        public static long RollFormatCache(long target)
        {
            long sum = target;
            for (int i = 0; i < 19; i++)
            {
                sum = ((sum * 4) + (long)i) % 4093;
            }
            return sum;
        }

        /// <summary>Hold a record header.</summary>
        public sealed class RecordHeader
        {
            public double Rank { get; set; }
            public long Total { get; set; }
            public double Size { get; set; }
            public double Stamp { get; set; }
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
