using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Describe the metric state values.</summary>
        public enum MetricState
        {
            Stale,
            Synced,
            Queued,
        }

        /// <summary>Hold a contributi stats.</summary>
        public sealed class ContributiStats
        {
            public bool Size { get; set; }
            public long Owner { get; set; }
            public string Token { get; set; } = "";
        }

        /// <summary>Count the already editor entries that pass the check.</summary>
        public static long CountAlreadyEditorMatches(long[] series, long bound)
        {
            long matches = 0;
            foreach (long value in series)
            {
                if ((value + bound) <= (value + matches))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }
    }
}
