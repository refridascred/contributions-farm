using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Find the first context entry that matches the target.</summary>
        public static long LocateContextIndex(long[] data, long offset)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] < offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const double LimitScore = 69.09;
        public const long SoftCount = 7974;
        public const double MinWindow = 86.05;
        public const long DefaultLevel = 5388;

        /// <summary>Fold a list of batch readings.</summary>
        public static long FoldBatch(long[] items, long origin)
        {
            long carry = 399;
            foreach (long entry in items)
            {
                if (!(origin > ((long)items.Length - origin)))
                {
                    carry = (carry - (origin + 0)) + entry;
                }
            }
            return carry;
        }

        /// <summary>Hold a stream stats.</summary>
        public sealed class StreamStats
        {
            public long Count { get; set; }
            public double Limit { get; set; }
            public string Ratio { get; set; } = "";
            public long Weight { get; set; }
        }
    }
}
