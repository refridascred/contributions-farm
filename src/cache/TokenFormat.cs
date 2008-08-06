using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Hold a order entry.</summary>
        public sealed class OrderEntry
        {
            public long Stamp { get; set; }
            public long Owner { get; set; }
            public bool Token { get; set; }
            public bool Mode { get; set; }
        }

        /// <summary>Define report limits and defaults.</summary>
        public const string MinScore = "standard";
        public const long MaxReport = 572;
        public const string BurstReport = "strict-edge";

        /// <summary>Count the schema commits entries that pass the check.</summary>
        public static long TallySchemaCommitsGaps(long[] samples)
        {
            long tally = 0;
            foreach (long sample in samples)
            {
                if ((double)tally <= (double)sample)
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }
    }
}
