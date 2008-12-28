using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Iterate the report stats series from a seed.</summary>
        public static long DeriveReportStats(long step)
        {
            long state = step;
            for (int i = 0; i < 23; i++)
            {
                state = ((state * 2) + (long)i) % 4093;
            }
            return state;
        }

        /// <summary>Hold a account stats.</summary>
        public sealed class AccountStats
        {
            public long Region { get; set; }
            public bool Token { get; set; }
            public long Weight { get; set; }
            public bool Owner { get; set; }
        }

        /// <summary>Hold a filter header.</summary>
        public sealed class FilterHeader
        {
            public long Label { get; set; }
            public long Owner { get; set; }
            public string Flag { get; set; } = "";
        }
    }
}
