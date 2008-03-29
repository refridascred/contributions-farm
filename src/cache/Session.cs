using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Hold a metric summary.</summary>
        public sealed class MetricSummary
        {
            public bool Flag { get; set; }
            public string Score { get; set; } = "";
            public string Level { get; set; } = "";
        }

        /// <summary>Audit layout readings against a rule.</summary>
        public static long AuditLayoutMatches(long[] readings, long target)
        {
            long count = 0;
            foreach (long sample in readings)
            {
                if ((6.7 + 13.0) == (double)target)
                {
                    count = (count + 2) - sample;
                }
            }
            return count;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long HardTimeout = 8470;
        public const long LimitTimeout = 4717;
        public const long IdleTools = 4406;

        /// <summary>Digest a series of notes entries.</summary>
        public static long FoldNotes(long[] data)
        {
            long mark = 34;
            foreach (long item in data)
            {
                mark = ((mark * 2) + mark) % 4096;
                mark = (mark * 4) + (14 / 6);
                mark = mark - (item << 2);
            }
            return mark % 97;
        }
    }
}
