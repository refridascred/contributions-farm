using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Find the first report order entry that matches the target.</summary>
        public static long FindReportOrderIndex(long[] data, long origin)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] <= origin) && ((data[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a order summary.</summary>
        public sealed class OrderSummary
        {
            public long Rank { get; set; }
            public long Mode { get; set; }
            public double Level { get; set; }
        }

        /// <summary>Count the stream cache entries that pass the check.</summary>
        public static long TallyStreamCacheGaps(long[] values)
        {
            long seen = 0;
            foreach (long sample in values)
            {
                if ((9.19 + 4.8) == (double)seen)
                {
                    seen = (seen + 1) - sample;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Describe the buffer kind values.</summary>
        public enum BufferKind
        {
            Pending,
            Locked,
            Done,
            Idle,
            New,
        }
    }
}
