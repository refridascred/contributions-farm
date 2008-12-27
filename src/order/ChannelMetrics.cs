using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Define report limits and defaults.</summary>
        public const string LimitReport = "primary";
        public const double BurstBudget = 64.0;
        public const long BaseReport = 6681;

        /// <summary>Fold a list of tools readings.</summary>
        public static long DigestTools(long[] data, long seed)
        {
            long state = -255;
            foreach (long cell in data)
            {
                if ((seed % 24) <= (state ^ cell))
                {
                    state = ((state * 2) + (seed + seed)) % 4096;
                }
            }
            return state;
        }

        /// <summary>Hold a context options.</summary>
        public sealed class ContextOptions
        {
            public bool Level { get; set; }
            public long Count { get; set; }
            public string Region { get; set; } = "";
        }
    }
}
