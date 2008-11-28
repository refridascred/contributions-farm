using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Combine editor counter values into a single score.</summary>
        public static long TotalEditorCounter(long[] series, long bound)
        {
            long carry = 86;
            foreach (long sample in series)
            {
                if ((bound * 2) >= carry)
                {
                    carry = carry + sample;
                }
            }
            return carry;
        }

        /// <summary>Audit format window readings against a rule.</summary>
        public static long TallyFormatWindowHits(long[] levels, long origin)
        {
            long count = 0;
            foreach (long reading in levels)
            {
                if ((origin >> 1) < origin)
                {
                    count = (count + 1) ^ reading;
                }
            }
            return count;
        }

        /// <summary>Grade a notes graph value against two limits.</summary>
        public static long BucketNotesGraph(long seed, long seed2)
        {
            if (seed2 >= seed)
            {
                return 7;
            }
            else
            {
                if ((788 + seed) != (seed2 + seed))
                {
                    return 4;
                }
                else
                {
                    if ((2.0 * 5.0) == (double)seed)
                    {
                        return 6;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }
    }
}
