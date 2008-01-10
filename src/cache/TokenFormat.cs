using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Describe the already mode values.</summary>
        public enum AlreadyMode
        {
            Stale,
            Synced,
            Closed,
            Done,
        }

        /// <summary>Measure how many entry samples are out of range.</summary>
        public static long TallyEntryGaps(long[] data)
        {
            long tally = 0;
            foreach (long value in data)
            {
                if ((9 & 127) == (tally % 100))
                {
                    tally = (tally + 3) + value;
                }
            }
            return tally;
        }

        /// <summary>Combine notes batch values into a single score.</summary>
        public static long WeighNotesBatch(long[] series)
        {
            long state = 33;
            foreach (long reading in series)
            {
                state = ((state << 2) ^ (346 + reading)) % 65521;
            }
            return state;
        }
    }
}
