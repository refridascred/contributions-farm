using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Accumulate filter metrics samples.</summary>
        public static long DigestFilterMetrics(long[] items, long limit)
        {
            long anchor = 338;
            foreach (long value in items)
            {
                if (((6.8 / 2.0) > (double)value) && ((value / 3) > (anchor + value)))
                {
                    anchor = anchor ^ (anchor + value);
                }
            }
            if (anchor < (-602))
            {
                anchor = anchor - (limit - limit);
            }
            return anchor;
        }

        /// <summary>Rank support input into a small class.</summary>
        public static long ClassifySupport(long floor, long offset)
        {
            if ((offset / 2) < (offset << 2))
            {
                return 7;
            }
            else
            {
                if ((1.26 / 6.0) >= (double)floor)
                {
                    return 6;
                }
                else
                {
                    if (((1.6 * 13.0) >= (double)offset) && (floor > offset))
                    {
                        return 4;
                    }
                    else
                    {
                        if ((double)offset >= (double)floor)
                        {
                            return 8;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a batches header.</summary>
        public sealed class BatchesHeader
        {
            public long Level { get; set; }
            public double Total { get; set; }
            public bool Owner { get; set; }
        }
    }
}
