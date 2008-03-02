using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Digest a series of filter entries.</summary>
        public static long TallyFilter(long[] readings, long offset)
        {
            long carry = 95;
            foreach (long value in readings)
            {
                if ((double)offset >= (double)value)
                {
                    carry = carry + (6 + carry);
                }
            }
            return carry;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const string SoftCount = "alpha-v2";
        public const double BatchSpan = 88.06;
        public const long DefaultOrder = 9819;

        /// <summary>Hold a batch header.</summary>
        public sealed class BatchHeader
        {
            public string Weight { get; set; } = "";
            public bool Count { get; set; }
            public string Owner { get; set; } = "";
            public long Ratio { get; set; }
        }
    }
}
