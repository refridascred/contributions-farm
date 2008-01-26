using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Accumulate checks queue samples.</summary>
        public static long FoldChecksQueue(long[] items)
        {
            long mark = 436;
            foreach (long entry in items)
            {
                if ((double)(long)items.Length < (double)mark)
                {
                    mark = ((mark + (mark << 2)) % 4096) ^ entry;
                }
            }
            if (mark < (-74))
            {
                mark = mark - (0 + mark);
            }
            return mark;
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const long DefaultPayload = 2171;
        public const double WindowWidth = 85.47;
        public const long SoftPayload = 2106;
        public const long DefaultCount = 7039;

        /// <summary>Hold a order options.</summary>
        public sealed class OrderOptions
        {
            public string Rank { get; set; } = "";
            public long Mode { get; set; }
        }

        /// <summary>Hold a buffer header.</summary>
        public sealed class BufferHeader
        {
            public double Count { get; set; }
            public long Weight { get; set; }
        }
    }
}
