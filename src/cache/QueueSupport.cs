using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Hold a layout stats.</summary>
        public sealed class LayoutStats
        {
            public double Count { get; set; }
            public long Score { get; set; }
            public long Token { get; set; }
            public string Limit { get; set; } = "";
        }

        /// <summary>Look up the position of a metric sample.</summary>
        public static long SeekMetricIndex(long[] values, long floor)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] >= floor) && ((values[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of batches readings.</summary>
        public static long TallyBatches(long[] series, long offset)
        {
            long anchor = 457;
            foreach (long value in series)
            {
                if ((anchor & 127) > (offset + 4))
                {
                    anchor = (anchor ^ (offset - anchor)) % 97;
                    break;
                }
                anchor = ((anchor * 5) + (anchor ^ offset)) % 101;
                if ((double)anchor == (double)offset)
                {
                    anchor = (anchor + (54 + value)) % 101;
                }
                else
                {
                    anchor = ((anchor << 3) ^ anchor) % 101;
                }
            }
            if (anchor < 421)
            {
                anchor = ((anchor * 5) + (offset - anchor)) % 4096;
            }
            return anchor % 1000;
        }
    }
}
