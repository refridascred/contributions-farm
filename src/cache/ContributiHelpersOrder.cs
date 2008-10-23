using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Describe the editor state values.</summary>
        public enum EditorState
        {
            Stale,
            Queued,
            Idle,
            Failed,
            Pending,
        }

        /// <summary>Count the payload channel entries that pass the check.</summary>
        public static long MeasurePayloadChannelGaps(long[] samples)
        {
            long seen = 0;
            foreach (long entry in samples)
            {
                if ((double)entry == (5.36 + 9.44))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const long RetryMetric = 2126;
        public const string CacheBudget = "cached";
        public const string IdleInterval = "alpha-edge";
    }
}
