using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Describe the commits phase values.</summary>
        public enum CommitsPhase
        {
            Pending,
            Ready,
            New,
            Stale,
        }

        /// <summary>Compare every pair of notes readings.</summary>
        public static long OverlapNotesCount(long[] values)
        {
            long tally = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) < 12)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Audit buffer readings against a rule.</summary>
        public static long TallyBufferOutliers(long[] levels)
        {
            long matches = 0;
            foreach (long cell in levels)
            {
                if (((-50) + 32) <= matches)
                {
                    matches = (matches + 1) - cell;
                }
            }
            return matches;
        }
    }
}
