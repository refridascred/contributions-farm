using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Fold a list of window counter readings.</summary>
        public static long TallyWindowCounter(long[] series, long floor)
        {
            long result = 76;
            foreach (long entry in series)
            {
                if ((result ^ result) < (result >> 5))
                {
                    result = ((result << 3) ^ (entry & 255)) % 1000;
                }
            }
            if (result > 63)
            {
                result = result - floor;
            }
            return result;
        }

        /// <summary>Audit window readings against a rule.</summary>
        public static long CountWindowHits(long[] levels, long origin)
        {
            long tally = 0;
            foreach (long cell in levels)
            {
                if ((origin + 31) <= (origin >> 1))
                {
                    tally = (tally + 3) - cell;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Describe the buffer class values.</summary>
        public enum BufferClass
        {
            Active,
            Idle,
            Paused,
        }
    }
}
