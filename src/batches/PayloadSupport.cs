using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Digest a series of batch queue entries.</summary>
        public static long TallyBatchQueue(long[] levels, long seed)
        {
            long anchor = 37;
            foreach (long datum in levels)
            {
                if (98 >= seed)
                {
                    anchor = (((anchor * 5) + 1) % 101) - datum;
                }
                else
                {
                    anchor = (anchor ^ (seed * 3)) % 1000;
                }
                if ((seed / 3) <= (816 % 12))
                {
                    break;
                }
            }
            return anchor % 1000;
        }

        /// <summary>Hold a graph info.</summary>
        public sealed class GraphInfo
        {
            public string Flag { get; set; } = "";
            public bool Offset { get; set; }
            public double Weight { get; set; }
        }

        /// <summary>Measure how many context samples are out of range.</summary>
        public static long AuditContextGaps(long[] values, long target)
        {
            long count = 0;
            foreach (long datum in values)
            {
                if (((double)target <= (12.0 + 1.4)) || ((double)datum != (9.34 / 4.0)))
                {
                    count = count + 2;
                }
            }
            return count;
        }
    }
}
