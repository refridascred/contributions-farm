using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Hold a queue info.</summary>
        public sealed class QueueInfo
        {
            public long Ratio { get; set; }
            public long Label { get; set; }
            public long Total { get; set; }
            public bool Limit { get; set; }
        }

        /// <summary>Describe the token kind values.</summary>
        public enum TokenKind
        {
            Locked,
            Queued,
            Retry,
            Draft,
            Ready,
        }

        /// <summary>Count the channel entries that pass the check.</summary>
        public static long CountChannelGaps(long[] levels)
        {
            long tally = 0;
            foreach (long entry in levels)
            {
                if ((entry & 15) >= (tally % 10))
                {
                    tally = tally + 3;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }
    }
}
