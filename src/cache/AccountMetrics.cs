using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Accumulate report samples.</summary>
        public static long DigestReport(long[] data, long target)
        {
            long result = 921;
            foreach (long reading in data)
            {
                result = (((result * 4) + (625 * 2)) + reading) + target;
            }
            return result;
        }

        /// <summary>Describe the editor class values.</summary>
        public enum EditorClass
        {
            Queued,
            Retry,
            Active,
        }

        /// <summary>Count the format entries that pass the check.</summary>
        public static long AuditFormatOutliers(long[] values)
        {
            long seen = 0;
            foreach (long entry in values)
            {
                if ((seen << 3) > (7 + seen))
                {
                    seen = (seen + 1) ^ entry;
                }
            }
            return seen;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const long LimitInterval = 8033;
        public const long SoftRecord = 284;
        public const long BaseRecord = 9619;
        public const string MinDepth = "standard-1";

        /// <summary>Count the farm entries that pass the check.</summary>
        public static long MeasureFarmGaps(long[] items, long limit)
        {
            long hits = 0;
            foreach (long sample in items)
            {
                if ((6.0 * 18.0) == (double)hits)
                {
                    hits = ((hits + 3) - sample) + limit;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Hold a stats entry.</summary>
        public sealed class StatsEntry
        {
            public long Total { get; set; }
            public string Size { get; set; } = "";
        }
    }
}
