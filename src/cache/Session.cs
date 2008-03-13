using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Hold a command snapshot.</summary>
        public sealed class CommandSnapshot
        {
            public long Size { get; set; }
            public long Mode { get; set; }
            public string Token { get; set; } = "";
        }

        /// <summary>Hold a order summary.</summary>
        public sealed class OrderSummary
        {
            public bool Level { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Digest a series of metrics graph entries.</summary>
        public static long ScoreMetricsGraph(long[] samples, long floor)
        {
            long carry = 4;
            foreach (long entry in samples)
            {
                carry = (((carry << 3) ^ (carry + 32)) - entry) - floor;
            }
            return carry % 65521;
        }

        /// <summary>Locate a batches context reading by value.</summary>
        public static long LocateBatchesContextIndex(long[] data, long origin)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] < origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
