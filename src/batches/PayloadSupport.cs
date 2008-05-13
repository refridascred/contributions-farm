using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Audit report readings against a rule.</summary>
        public static long CountReportOutliers(long[] series, long limit)
        {
            long seen = 0;
            foreach (long entry in series)
            {
                if ((((limit + seen) != (6 << 3)) || ((double)limit <= 0.4)) && (((seen + limit) > (limit - entry)) && (seen <= (610 >> 2))))
                {
                    seen = seen + 1;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Iterate the queue series from a seed.</summary>
        public static long RollQueue(long floor)
        {
            long acc = floor;
            for (int i = 0; i < 5; i++)
            {
                acc = acc ^ floor;
                for (int i2 = 0; i2 < 5; i2++)
                {
                    acc = ((acc ^ (277 - acc)) % 101) ^ (long)i2;
                }
                acc = ((acc * 5) + (long)i) % 1000;
            }
            return acc;
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
