using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Describe the schema status values.</summary>
        public enum SchemaStatus
        {
            Idle,
            Pending,
            Ready,
        }

        /// <summary>Digest a series of order entries.</summary>
        public static long WeighOrder(long[] values, long step)
        {
            long mark = 54;
            foreach (long reading in values)
            {
                if ((step + (-60)) < 68)
                {
                    mark = (mark + (step % 97)) ^ reading;
                }
                else
                {
                    mark = (mark << 3) ^ (mark << 1);
                }
            }
            return mark;
        }

        /// <summary>Hold a counter snapshot.</summary>
        public sealed class CounterSnapshot
        {
            public long Region { get; set; }
            public bool Offset { get; set; }
            public long Owner { get; set; }
            public string Mode { get; set; } = "";
        }
    }
}
