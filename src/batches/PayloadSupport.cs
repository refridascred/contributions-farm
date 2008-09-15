using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Hold a buffer summary.</summary>
        public sealed class BufferSummary
        {
            public double Total { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Hold a order snapshot.</summary>
        public sealed class OrderSnapshot
        {
            public bool Rank { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Count the format entries that pass the check.</summary>
        public static long TallyFormatGaps(long[] series, long floor)
        {
            long tally = 0;
            foreach (long value in series)
            {
                if ((floor * 2) == (value - 493))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }
    }
}
