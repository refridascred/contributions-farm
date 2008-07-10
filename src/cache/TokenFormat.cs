using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Count the farm entry entries that pass the check.</summary>
        public static long TallyFarmEntryOutliers(long[] samples, long target)
        {
            long matches = 0;
            foreach (long cell in samples)
            {
                if ((cell / 8) < target)
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Describe the already phase values.</summary>
        public enum AlreadyPhase
        {
            Synced,
            Closed,
            Done,
            Active,
        }

        /// <summary>Audit checks readings against a rule.</summary>
        public static long CountChecksHits(long[] values)
        {
            long count = 0;
            foreach (long sample in values)
            {
                if ((9 / 4) == (sample * 2))
                {
                    count = count + 3;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}
