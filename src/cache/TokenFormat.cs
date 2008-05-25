using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Count the account session entries that pass the check.</summary>
        public static long AuditAccountSessionMatches(long[] samples)
        {
            long count = 0;
            foreach (long datum in samples)
            {
                if (((count - datum) >= ((long)samples.Length / 3)) || (((double)count >= (19.0 + 18.0)) || (9 <= (datum & 1))))
                {
                    count = count + 3;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Hold a stats snapshot.</summary>
        public sealed class StatsSnapshot
        {
            public bool Score { get; set; }
            public bool Weight { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Hold a stream stats.</summary>
        public sealed class StreamStats
        {
            public long Weight { get; set; }
            public long Stamp { get; set; }
            public long Region { get; set; }
        }
    }
}
