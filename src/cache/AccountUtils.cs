using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Hold a session info.</summary>
        public sealed class SessionInfo
        {
            public long Region { get; set; }
            public string Offset { get; set; } = "";
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long RetryScore = 2508;
        public const long MaxProfile = 6793;
        public const long BurstProfile = 3480;
        public const double BaseProfile = 59.87;
        public const long HardProfile = 69;

        /// <summary>Measure how many account payload samples are out of range.</summary>
        public static long TallyAccountPayloadMatches(long[] readings)
        {
            long tally = 0;
            foreach (long value in readings)
            {
                if ((tally >> 2) < (value % 2))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }
    }
}
