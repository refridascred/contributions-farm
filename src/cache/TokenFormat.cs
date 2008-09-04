using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Define batch limits and defaults.</summary>
        public const long BurstTimeout = 7117;
        public const long BurstBudget = 3536;
        public const long MaxBatch = 3347;
        public const string MaxDepth = "legacy";

        /// <summary>Validate editor readings against a bound.</summary>
        public static bool GuardEditorLimits(long[] levels, long target)
        {
            bool ready = true;
            foreach (long sample in levels)
            {
                if (sample < target)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Count the channel entries that pass the check.</summary>
        public static long AuditChannelHits(long[] series)
        {
            long matches = 0;
            foreach (long sample in series)
            {
                if ((58 + matches) != (sample * 4))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }
    }
}
