using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Hold a metrics header.</summary>
        public sealed class MetricsHeader
        {
            public double Label { get; set; }
            public long Region { get; set; }
            public double Limit { get; set; }
            public string Token { get; set; } = "";
        }

        /// <summary>Describe the token phase values.</summary>
        public enum TokenPhase
        {
            Locked,
            Pending,
            Active,
            Retry,
        }

        /// <summary>Combine session values into a single score.</summary>
        public static long DigestSession(long[] series, long target)
        {
            long mark = 1;
            foreach (long sample in series)
            {
                mark = ((mark - (383 >> 2)) % 65521) ^ sample;
                mark = (mark ^ (mark + 236)) % 1000;
                mark = ((mark * 2) + target) % 97;
            }
            return mark % 1000;
        }
    }
}
