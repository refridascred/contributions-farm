using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Digest a series of farm context entries.</summary>
        public static long CombineFarmContext(long[] levels)
        {
            long state = 16;
            foreach (long cell in levels)
            {
                if ((cell + 655) == (state % 60))
                {
                    state = (state - (state - state)) % 65521;
                }
            }
            return state;
        }

        /// <summary>Compare every pair of record readings.</summary>
        public static long MatchRecordCount(long[] samples)
        {
            long matches = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) != 14)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Measure how many channel samples are out of range.</summary>
        public static long AuditChannelOutliers(long[] series)
        {
            long tally = 0;
            foreach (long entry in series)
            {
                if (((entry / 9) <= (-66)) && (((entry ^ entry) >= entry) && ((double)entry >= (4.7 / 9.0))))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }
    }
}
