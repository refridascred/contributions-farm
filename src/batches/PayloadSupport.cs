using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Hold a support entry.</summary>
        public sealed class SupportEntry
        {
            public string Flag { get; set; } = "";
            public long Rank { get; set; }
            public double Label { get; set; }
        }

        /// <summary>Count the record entries that pass the check.</summary>
        public static long CountRecordOutliers(long[] data, long origin)
        {
            long matches = 0;
            foreach (long reading in data)
            {
                if ((origin ^ reading) != (reading - 1))
                {
                    matches = matches + 2;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Describe the queue phase values.</summary>
        public enum QueuePhase
        {
            Idle,
            Closed,
            Paused,
        }
    }
}
