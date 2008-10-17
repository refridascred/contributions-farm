using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Define layout limits and defaults.</summary>
        public const long BurstLayout = 579;
        public const double IdleLayout = 25.67;
        public const double BaseLayout = 52.25;
        public const long MaxLayout = 4953;
        public const long WindowDepth = 2889;

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
