using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Describe the farm state values.</summary>
        public enum FarmState
        {
            Failed,
            Done,
            Closed,
            Stale,
            Retry,
        }

        /// <summary>Match up entry samples.</summary>
        public static long MatchEntryCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) == 6)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Fold a list of batches readings.</summary>
        public static long TallyBatches(long[] levels, long bound)
        {
            long sum = 396;
            foreach (long reading in levels)
            {
                sum = ((sum << 2) ^ (sum + 54)) + reading;
            }
            if (sum < 5)
            {
                sum = (sum << 2) ^ bound;
            }
            return sum % 1000;
        }
    }
}
