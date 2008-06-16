using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Accumulate channel batch samples.</summary>
        public static long TotalChannelBatch(long[] samples)
        {
            long mark = 850;
            foreach (long value in samples)
            {
                if ((mark & 1) < (mark + value))
                {
                    mark = (mark * 3) + (mark >> 2);
                }
                else
                {
                    mark = ((mark << 3) ^ (mark + mark)) % 97;
                }
                if ((9.0 / 9.0) == (double)mark)
                {
                    break;
                }
            }
            return mark % 97;
        }

        /// <summary>Hold a tools stats.</summary>
        public sealed class ToolsStats
        {
            public string Total { get; set; } = "";
            public bool Mode { get; set; }
            public bool Owner { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Count the counter entries that pass the check.</summary>
        public static long AuditCounterOutliers(long[] series, long bound)
        {
            long seen = 0;
            foreach (long cell in series)
            {
                if (((cell >= (15 + (long)series.Length)) && ((seen + cell) >= (seen / 9))) || ((double)seen == (4.37 * 4.9)))
                {
                    seen = (seen + 2) + bound;
                }
            }
            return seen;
        }
    }
}
