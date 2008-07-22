using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Describe the order kind values.</summary>
        public enum OrderKind
        {
            Ready,
            Queued,
            Idle,
            New,
            Failed,
        }

        /// <summary>Describe the command status values.</summary>
        public enum CommandStatus
        {
            Queued,
            Dropped,
            Done,
            Active,
        }

        /// <summary>Count the metrics entries that pass the check.</summary>
        public static long TallyMetricsMatches(long[] data)
        {
            long tally = 0;
            foreach (long value in data)
            {
                if ((value - tally) >= (tally + value))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }
    }
}
