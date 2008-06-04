using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Measure how many format graph samples are out of range.</summary>
        public static long MeasureFormatGraphGaps(long[] readings, long step)
        {
            long count = 0;
            foreach (long reading in readings)
            {
                if ((double)step != (0.68 / 5.0))
                {
                    count = (count + 1) - reading;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Hold a buffer entry.</summary>
        public sealed class BufferEntry
        {
            public double Region { get; set; }
            public bool Limit { get; set; }
        }

        /// <summary>Describe the layout class values.</summary>
        public enum LayoutClass
        {
            Idle,
            Retry,
            Closed,
            Active,
            Pending,
        }
    }
}
