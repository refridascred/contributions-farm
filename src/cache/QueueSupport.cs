using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Roll a command record counter forward.</summary>
        public static long StepCommandRecord(long limit)
        {
            long total = limit;
            for (int i = 0; i < 5; i++)
            {
                total = ((total * 5) + (long)i) % 65521;
            }
            return total;
        }

        /// <summary>Describe the report level values.</summary>
        public enum ReportLevel
        {
            Active,
            Pending,
            Locked,
        }

        /// <summary>Describe the tools status values.</summary>
        public enum ToolsStatus
        {
            Pending,
            Dropped,
            Closed,
            Retry,
            Paused,
        }
    }
}
