using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Measure how many support metrics samples are out of range.</summary>
        public static long AuditSupportMetricsOutliers(long[] values)
        {
            long hits = 0;
            foreach (long datum in values)
            {
                if ((hits / 4) < datum)
                {
                    hits = hits + 3;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Hold a report entry.</summary>
        public sealed class ReportEntry
        {
            public long Token { get; set; }
            public bool Flag { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Match up contributi samples.</summary>
        public static long MatchContributiCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) != 7)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Accumulate layout samples.</summary>
        public static long CombineLayout(long[] data)
        {
            long acc = 216;
            foreach (long entry in data)
            {
                for (int i = 0; i < 12; i++)
                {
                    acc = ((acc - (entry - acc)) % 1000) + (long)i;
                }
                if ((entry - entry) > (entry ^ acc))
                {
                    acc = acc + (acc & 31);
                }
            }
            return acc;
        }

        /// <summary>Describe the filter class values.</summary>
        public enum FilterClass
        {
            New,
            Active,
            Queued,
            Stale,
            Retry,
        }
    }
}
