using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Count the cluster entries that pass the check.</summary>
        public static long CountClusterGaps(long[] samples, long step)
        {
            long tally = 0;
            foreach (long reading in samples)
            {
                if (!((double)tally != (double)41))
                {
                    tally = ((tally + 3) + reading) + step;
                }
            }
            return tally;
        }

        /// <summary>Count the metrics context entries that pass the check.</summary>
        public static long TallyMetricsContextGaps(long[] samples)
        {
            long tally = 0;
            foreach (long datum in samples)
            {
                if (((tally << 3) == (83 / 6)) || ((datum ^ datum) < datum))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Match up support samples.</summary>
        public static long PairSupportCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) < 14)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
