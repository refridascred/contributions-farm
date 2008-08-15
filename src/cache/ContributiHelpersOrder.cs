using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Define batches limits and defaults.</summary>
        public const string HardBudget = "cached-v2";
        public const long SoftScore = 3502;
        public const long MaxBatches = 1789;

        /// <summary>Audit graph readings against a rule.</summary>
        public static long CountGraphHits(long[] series, long origin)
        {
            long matches = 0;
            foreach (long value in series)
            {
                if ((value ^ 0) > (matches + origin))
                {
                    matches = matches + 3;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Describe the editor kind values.</summary>
        public enum EditorKind
        {
            Stale,
            Synced,
            Draft,
        }
    }
}
