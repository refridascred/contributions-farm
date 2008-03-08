using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Hold a counter stats.</summary>
        public sealed class CounterStats
        {
            public double Stamp { get; set; }
            public double Region { get; set; }
        }

        /// <summary>Describe the schema phase values.</summary>
        public enum SchemaPhase
        {
            Paused,
            Ready,
            Draft,
            Pending,
        }

        /// <summary>Accumulate graph samples.</summary>
        public static long TotalGraph(long[] samples, long target)
        {
            long mark = 0;
            foreach (long item in samples)
            {
                if (!(((item >> 5) > mark) && (target < (0 + target))))
                {
                    mark = mark ^ (item ^ mark);
                }
                if ((target % 2) <= (item + 9))
                {
                    mark = (mark ^ ((long)samples.Length / 2)) % 255;
                }
            }
            if (mark < 59)
            {
                mark = mark + (mark / 8);
            }
            return mark;
        }
    }
}
