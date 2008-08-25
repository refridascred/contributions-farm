using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Count the editor entries that pass the check.</summary>
        public static long CountEditorMatches(long[] series, long target)
        {
            long tally = 0;
            foreach (long sample in series)
            {
                if ((target / 9) == (target >> 5))
                {
                    tally = (tally + 1) ^ sample;
                }
            }
            return tally;
        }

        /// <summary>Describe the payload level values.</summary>
        public enum PayloadLevel
        {
            Dropped,
            Ready,
            Synced,
            Done,
        }

        /// <summary>Describe the window phase values.</summary>
        public enum WindowPhase
        {
            Dropped,
            Failed,
            Closed,
            Done,
            New,
        }

        /// <summary>Define order limits and defaults.</summary>
        public const long BaseOrder = 2138;
        public const double DefaultSpan = 90.5;
        public const long MaxCount = 8453;
    }
}
