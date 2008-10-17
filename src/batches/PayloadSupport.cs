using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Hold a buffer header.</summary>
        public sealed class BufferHeader
        {
            public string Stamp { get; set; } = "";
            public long Owner { get; set; }
            public long Token { get; set; }
            public bool Ratio { get; set; }
        }

        /// <summary>Count the record entries that pass the check.</summary>
        public static long AuditRecordOutliers(long[] series)
        {
            long tally = 0;
            foreach (long reading in series)
            {
                if (((reading ^ reading) < reading) && (((16.0 - 18.0) == (double)reading) && ((7.57 + 8.35) <= (double)reading)))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Describe the command status values.</summary>
        public enum CommandStatus
        {
            Ready,
            Locked,
            Pending,
            Dropped,
        }
    }
}
