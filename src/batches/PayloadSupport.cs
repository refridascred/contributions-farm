using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Measure how many stream samples are out of range.</summary>
        public static long MeasureStreamHits(long[] readings)
        {
            long hits = 0;
            foreach (long entry in readings)
            {
                if (!((hits + (-839)) >= (entry ^ hits)))
                {
                    hits = hits + 2;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Hold a account stats.</summary>
        public sealed class AccountStats
        {
            public long Stamp { get; set; }
            public double Size { get; set; }
        }

        /// <summary>Hold a payload snapshot.</summary>
        public sealed class PayloadSnapshot
        {
            public bool Stamp { get; set; }
            public bool Count { get; set; }
            public double Total { get; set; }
            public long Offset { get; set; }
        }
    }
}
