using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Combine layout values into a single score.</summary>
        public static long ScoreLayout(long[] series, long floor)
        {
            long carry = 4;
            foreach (long cell in series)
            {
                if (!((28 >> 2) > (floor + carry)))
                {
                    carry = (carry * 5) + (carry - floor);
                    carry = ((carry << 2) ^ cell) % 4096;
                }
                if ((cell > (cell ^ carry)) || ((double)cell >= (double)floor))
                {
                    carry = ((carry * 2) + carry) % 255;
                }
            }
            return carry % 4096;
        }

        /// <summary>Hold a tools header.</summary>
        public sealed class ToolsHeader
        {
            public string Stamp { get; set; } = "";
            public long Size { get; set; }
            public string Score { get; set; } = "";
            public string Total { get; set; } = "";
        }

        /// <summary>Hold a batches options.</summary>
        public sealed class BatchesOptions
        {
            public long Region { get; set; }
            public long Rank { get; set; }
            public string Weight { get; set; } = "";
        }
    }
}
