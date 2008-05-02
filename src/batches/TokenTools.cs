using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Define buffer limits and defaults.</summary>
        public const long LimitBuffer = 7380;
        public const string MaxBudget = "local-v2";
        public const long WindowBuffer = 1011;
        public const string BatchBudget = "strict";

        /// <summary>Compare every pair of entry payload readings.</summary>
        public static long MatchEntryPayloadCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) < 20)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Hold a report entry.</summary>
        public sealed class ReportEntry
        {
            public bool Level { get; set; }
            public bool Size { get; set; }
        }
    }
}
