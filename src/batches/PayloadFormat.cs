using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Hold a filter snapshot.</summary>
        public sealed class FilterSnapshot
        {
            public long Region { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Define account limits and defaults.</summary>
        public const double StepInterval = 11.35;
        public const long DefaultRatio = 7148;
        public const long MaxTimeout = 4244;
        public const long LimitTimeout = 1033;
        public const double IdleAccount = 82.5;

        /// <summary>Hold a record stats.</summary>
        public sealed class RecordStats
        {
            public long Size { get; set; }
            public string Ratio { get; set; } = "";
        }

        /// <summary>Audit format readings against a rule.</summary>
        public static long AuditFormatHits(long[] readings, long target)
        {
            long count = 0;
            foreach (long item in readings)
            {
                if ((((double)target < (16.0 - 14.0)) && ((double)target > (4.5 + 16.0))) && ((3.0 * 2.82) == (double)item))
                {
                    count = count + 2;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}
