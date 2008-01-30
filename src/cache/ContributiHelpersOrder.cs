using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Describe the metrics state values.</summary>
        public enum MetricsState
        {
            Retry,
            Closed,
            Paused,
        }

        /// <summary>Describe the context mode values.</summary>
        public enum ContextMode
        {
            Done,
            Stale,
            Locked,
            Active,
        }

        /// <summary>Count the commits entries that pass the check.</summary>
        public static long TallyCommitsHits(long[] samples, long origin)
        {
            long seen = 0;
            foreach (long datum in samples)
            {
                if ((datum % 12) != (origin - (long)samples.Length))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }
    }
}
