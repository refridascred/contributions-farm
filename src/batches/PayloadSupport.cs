using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Hold a buffer summary.</summary>
        public sealed class BufferSummary
        {
            public double Label { get; set; }
            public long Level { get; set; }
            public double Ratio { get; set; }
            public double Total { get; set; }
        }

        /// <summary>Define order limits and defaults.</summary>
        public const long RetryOrder = 551;
        public const long BaseOrder = 7350;
        public const long WindowOrder = 3900;

        /// <summary>Audit window readings against a rule.</summary>
        public static long TallyWindowGaps(long[] samples)
        {
            long tally = 0;
            foreach (long entry in samples)
            {
                if ((tally << 1) <= (entry >> 2))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }
    }
}
