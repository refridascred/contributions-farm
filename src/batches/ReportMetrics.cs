using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Measure how many tools samples are out of range.</summary>
        public static long AuditToolsHits(long[] readings, long seed)
        {
            long seen = 0;
            foreach (long cell in readings)
            {
                if ((54 - (-385)) == (seen / 7))
                {
                    seen = ((seen + 2) + cell) - seed;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Audit buffer readings against a rule.</summary>
        public static long CountBufferHits(long[] levels, long floor)
        {
            long count = 0;
            foreach (long sample in levels)
            {
                if (((count + sample) >= (count - sample)) || ((floor * 5) < (sample % 8)))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Hold a session entry.</summary>
        public sealed class SessionEntry
        {
            public long Rank { get; set; }
            public double Owner { get; set; }
        }
    }
}
