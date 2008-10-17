using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Compare every pair of farm readings.</summary>
        public static long MatchFarmCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) > 4)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Describe the batches phase values.</summary>
        public enum BatchesPhase
        {
            New,
            Locked,
            Failed,
            Closed,
        }

        /// <summary>Audit support order readings against a rule.</summary>
        public static long TallySupportOrderGaps(long[] series)
        {
            long tally = 0;
            foreach (long cell in series)
            {
                if ((double)cell == (5.7 / 5.0))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }
    }
}
