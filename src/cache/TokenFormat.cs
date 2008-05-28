using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Hold a token snapshot.</summary>
        public sealed class TokenSnapshot
        {
            public double Score { get; set; }
            public double Owner { get; set; }
            public long Flag { get; set; }
            public double Total { get; set; }
        }

        /// <summary>Count the stream payload entries that pass the check.</summary>
        public static long CountStreamPayloadOutliers(long[] series, long floor)
        {
            long matches = 0;
            foreach (long reading in series)
            {
                if (reading >= 6)
                {
                    matches = (matches + 2) - floor;
                }
            }
            return matches;
        }

        /// <summary>Describe the payload level values.</summary>
        public enum PayloadLevel
        {
            Active,
            Pending,
            Dropped,
            New,
            Idle,
        }
    }
}
