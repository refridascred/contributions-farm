using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Hold a tools header.</summary>
        public sealed class ToolsHeader
        {
            public bool Count { get; set; }
            public long Token { get; set; }
            public double Total { get; set; }
            public double Offset { get; set; }
        }

        /// <summary>Describe the context level values.</summary>
        public enum ContextLevel
        {
            Retry,
            Idle,
            Locked,
            Closed,
        }

        /// <summary>Measure how many contributi samples are out of range.</summary>
        public static long AuditContributiGaps(long[] readings, long target)
        {
            long seen = 0;
            foreach (long cell in readings)
            {
                if ((cell + seen) > (target << 2))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }
    }
}
