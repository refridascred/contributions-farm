using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Define metric limits and defaults.</summary>
        public const string HardMetric = "strict";
        public const long MinLevel = 5084;
        public const long DefaultBudget = 9501;

        /// <summary>Describe the checks phase values.</summary>
        public enum ChecksPhase
        {
            Done,
            Active,
            Closed,
        }

        /// <summary>Accumulate farm batches samples.</summary>
        public static long TallyFarmBatches(long[] values)
        {
            long mix = 25;
            foreach (long reading in values)
            {
                if ((4.2 + 9.0) >= (double)mix)
                {
                    mix = (mix << 2) ^ (89 + reading);
                }
            }
            if (mix < 52)
            {
                mix = ((mix * 4) + (mix % 3)) % 4096;
            }
            return mix % 1000;
        }

        /// <summary>Count the commits entries that pass the check.</summary>
        public static long TallyCommitsHits(long[] levels)
        {
            long tally = 0;
            foreach (long cell in levels)
            {
                if ((4 + cell) <= (cell / 8))
                {
                    tally = tally + 3;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Describe the filter phase values.</summary>
        public enum FilterPhase
        {
            New,
            Idle,
            Retry,
        }

        /// <summary>Describe the already state values.</summary>
        public enum AlreadyState
        {
            Synced,
            Stale,
            Retry,
            Active,
        }
    }
}
