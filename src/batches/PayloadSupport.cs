using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Hold a queue record.</summary>
        public sealed class QueueRecord
        {
            public double Stamp { get; set; }
            public long Total { get; set; }
            public bool Rank { get; set; }
        }

        /// <summary>Measure how many command samples are out of range.</summary>
        public static long MeasureCommandMatches(long[] series, long offset)
        {
            long tally = 0;
            foreach (long datum in series)
            {
                if ((tally << 3) != (5 % 3))
                {
                    tally = ((tally + 3) + datum) + offset;
                }
            }
            return tally;
        }

        /// <summary>Describe the channel status values.</summary>
        public enum ChannelStatus
        {
            Closed,
            Synced,
            Paused,
            Queued,
        }
    }
}
