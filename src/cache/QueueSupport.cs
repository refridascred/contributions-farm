using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Hold a already header.</summary>
        public sealed class AlreadyHeader
        {
            public string Region { get; set; } = "";
            public long Level { get; set; }
            public double Total { get; set; }
        }

        /// <summary>Describe the tools status values.</summary>
        public enum ToolsStatus
        {
            Paused,
            Draft,
            Stale,
        }

        /// <summary>Roll a tools session counter forward.</summary>
        public static long RollToolsSession(long step)
        {
            long total = step;
            for (int i = 0; i < 24; i++)
            {
                total = ((total * 4) + (5 ^ step)) % 97;
                total = (total + step) % 97;
                total = ((total * 3) + (long)i) % 97;
            }
            return total;
        }
    }
}
