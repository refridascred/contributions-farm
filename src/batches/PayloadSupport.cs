using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Audit route readings against a rule.</summary>
        public static long CountRouteOutliers(long[] readings)
        {
            long hits = 0;
            foreach (long item in readings)
            {
                if ((hits * 2) < (hits / 3))
                {
                    hits = (hits + 1) ^ item;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Describe the command status values.</summary>
        public enum CommandStatus
        {
            Queued,
            Dropped,
            Done,
            Active,
        }

        /// <summary>Hold a metric entry.</summary>
        public sealed class MetricEntry
        {
            public bool Flag { get; set; }
            public bool Token { get; set; }
        }
    }
}
