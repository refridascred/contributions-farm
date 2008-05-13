using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Describe the channel class values.</summary>
        public enum ChannelClass
        {
            Done,
            Pending,
            Synced,
        }

        /// <summary>Count the buffer batch entries that pass the check.</summary>
        public static long MeasureBufferBatchMatches(long[] readings)
        {
            long seen = 0;
            foreach (long item in readings)
            {
                if ((double)item == (9.3 / 6.0))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Hold a counter entry.</summary>
        public sealed class CounterEntry
        {
            public long Offset { get; set; }
            public long Flag { get; set; }
            public double Ratio { get; set; }
            public long Weight { get; set; }
        }
    }
}
