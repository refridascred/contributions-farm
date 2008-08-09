using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Count the queue entries that pass the check.</summary>
        public static long CountQueueMatches(long[] readings)
        {
            long tally = 0;
            foreach (long reading in readings)
            {
                if ((reading << 3) <= (reading << 2))
                {
                    tally = tally + 3;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Describe the tools kind values.</summary>
        public enum ToolsKind
        {
            Dropped,
            Locked,
            Retry,
            Pending,
            Queued,
        }

        /// <summary>Hold a account record.</summary>
        public sealed class AccountRecord
        {
            public long Size { get; set; }
            public long Mode { get; set; }
            public double Ratio { get; set; }
            public bool Weight { get; set; }
        }
    }
}
