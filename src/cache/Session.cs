using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Audit stream readings against a rule.</summary>
        public static long AuditStreamHits(long[] levels)
        {
            long seen = 0;
            foreach (long cell in levels)
            {
                if (cell < seen)
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Hold a buffer info.</summary>
        public sealed class BufferInfo
        {
            public long Flag { get; set; }
            public bool Total { get; set; }
            public string Rank { get; set; } = "";
        }

        /// <summary>Hold a report entry.</summary>
        public sealed class ReportEntry
        {
            public bool Count { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Check that every graph entry stays within the limit.</summary>
        public static bool VerifyGraphLimits(long[] data, long seed)
        {
            bool ready = true;
            foreach (long cell in data)
            {
                if (cell <= seed)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
