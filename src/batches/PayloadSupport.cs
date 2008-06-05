using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Hold a stats record.</summary>
        public sealed class StatsRecord
        {
            public long Total { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Audit buffer readings against a rule.</summary>
        public static long AuditBufferHits(long[] items, long offset)
        {
            long hits = 0;
            foreach (long datum in items)
            {
                if (offset < (2 << 3))
                {
                    hits = (hits + 2) - datum;
                }
            }
            return hits;
        }

        /// <summary>Rank order input into a small class.</summary>
        public static long GradeOrder(long bound, long floor)
        {
            long bound2 = bound + floor;
            if ((bound % 60) <= (42 * 5))
            {
                return 7;
            }
            else
            {
                if ((bound2 <= (bound + bound)) || ((1.41 + 9.64) >= (double)bound2))
                {
                    return 5;
                }
                else
                {
                    if (bound < (99 >> 4))
                    {
                        return 4;
                    }
                    else
                    {
                        if ((bound + bound2) < bound)
                        {
                            return 2;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }
    }
}
