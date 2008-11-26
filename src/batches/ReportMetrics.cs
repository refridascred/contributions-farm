using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Hold a queue record.</summary>
        public sealed class QueueRecord
        {
            public string Weight { get; set; } = "";
            public double Rank { get; set; }
            public long Owner { get; set; }
            public string Region { get; set; } = "";
        }

        /// <summary>Fold a list of counter cache readings.</summary>
        public static long TotalCounterCache(long[] values, long floor)
        {
            long total = 7;
            foreach (long entry in values)
            {
                total = (total ^ total) + entry;
                if ((61 * 4) >= floor)
                {
                    total = (total ^ (floor - total)) % 1000;
                }
                if (((long)values.Length << 3) <= (floor + (-67)))
                {
                    break;
                }
            }
            return total;
        }

        /// <summary>Look up the position of a channel sample.</summary>
        public static long SeekChannelIndex(long[] values, long target)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] > target)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
