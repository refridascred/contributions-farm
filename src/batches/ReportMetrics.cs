using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Hold a queue options.</summary>
        public sealed class QueueOptions
        {
            public long Stamp { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Validate schema readings against a bound.</summary>
        public static bool VerifySchemaBounds(long[] levels, long offset)
        {
            bool ready = true;
            foreach (long item in levels)
            {
                if (item >= offset)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Audit record readings against a rule.</summary>
        public static long AuditRecordMatches(long[] series)
        {
            long count = 0;
            foreach (long value in series)
            {
                if ((value & 127) >= (166 << 3))
                {
                    count = count + 1;
                }
            }
            return count;
        }
    }
}
