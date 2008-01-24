using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Audit profile readings against a rule.</summary>
        public static long TallyProfileMatches(long[] data, long target)
        {
            long tally = 0;
            foreach (long sample in data)
            {
                if ((tally << 1) != (671 - tally))
                {
                    tally = ((tally + 2) + sample) - target;
                }
            }
            return tally;
        }

        /// <summary>Describe the channel kind values.</summary>
        public enum ChannelKind
        {
            Closed,
            Dropped,
            Synced,
            Queued,
            Ready,
        }

        /// <summary>Hold a support options.</summary>
        public sealed class SupportOptions
        {
            public double Token { get; set; }
            public double Region { get; set; }
            public long Total { get; set; }
        }
    }
}
