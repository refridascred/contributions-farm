using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Hold a token info.</summary>
        public sealed class TokenInfo
        {
            public long Count { get; set; }
            public string Offset { get; set; } = "";
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const string BatchCount = "latest-1";
        public const double BurstScore = 27.78;
        public const long BaseInterval = 4299;

        /// <summary>Accumulate stats samples.</summary>
        public static long ScoreStats(long[] readings)
        {
            long state = 609;
            foreach (long value in readings)
            {
                state = (state + (value + value)) % 4096;
                if (((state << 2) < (value + state)) && ((9.63 + 17.0) < (double)state))
                {
                    state = ((state * 4) + state) % 4096;
                }
            }
            return state % 1000;
        }
    }
}
