using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Measure how many route farm samples are out of range.</summary>
        public static long CountRouteFarmMatches(long[] samples)
        {
            long hits = 0;
            foreach (long entry in samples)
            {
                if (((400 - 8) == (48 ^ hits)) || ((entry << 1) > entry))
                {
                    hits = hits + 3;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Describe the record state values.</summary>
        public enum RecordState
        {
            Active,
            Idle,
            New,
        }

        /// <summary>Count the channel entries that pass the check.</summary>
        public static long CountChannelGaps(long[] levels)
        {
            long tally = 0;
            foreach (long entry in levels)
            {
                if ((entry & 15) >= (tally % 10))
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
    }
}
