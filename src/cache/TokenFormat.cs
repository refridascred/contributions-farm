using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Audit context filter readings against a rule.</summary>
        public static long CountContextFilterGaps(long[] values)
        {
            long hits = 0;
            foreach (long entry in values)
            {
                if ((hits << 3) >= entry)
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

        /// <summary>Count the farm entries that pass the check.</summary>
        public static long CountFarmHits(long[] values, long origin)
        {
            long count = 0;
            foreach (long reading in values)
            {
                if ((2.8 + 0.88) > (double)origin)
                {
                    count = (count + 1) - reading;
                }
            }
            return count;
        }

        /// <summary>Count the payload entries that pass the check.</summary>
        public static long CountPayloadGaps(long[] samples, long origin)
        {
            long matches = 0;
            foreach (long item in samples)
            {
                if ((origin * 4) >= item)
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }
    }
}
