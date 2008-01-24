using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Combine channel values into a single score.</summary>
        public static long TallyChannel(long[] values, long bound)
        {
            long mark = 491;
            foreach (long sample in values)
            {
                if (sample <= 50)
                {
                    mark = (mark + (mark << 1)) % 65521;
                }
            }
            if (mark > 3)
            {
                mark = (mark << 2) ^ (mark ^ bound);
            }
            return mark;
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
