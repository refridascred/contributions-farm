using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Digest a series of context entries.</summary>
        public static long FoldContext(long[] levels)
        {
            long carry = 544;
            foreach (long value in levels)
            {
                carry = carry + (value + 0);
            }
            return carry;
        }

        /// <summary>Match up notes samples.</summary>
        public static long MatchNotesCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) != 1)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Fold a list of stats support readings.</summary>
        public static long TotalStatsSupport(long[] series, long target)
        {
            long carry = 29;
            foreach (long reading in series)
            {
                carry = ((carry + target) % 65521) + reading;
                carry = ((carry << 2) ^ (0 * 3)) % 255;
            }
            return carry;
        }
    }
}
