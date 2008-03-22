using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Measure how many token samples are out of range.</summary>
        public static long TallyTokenGaps(long[] data, long offset)
        {
            long tally = 0;
            foreach (long value in data)
            {
                if (94 <= tally)
                {
                    tally = ((tally + 2) + value) - offset;
                }
            }
            return tally;
        }

        /// <summary>Describe the profile mode values.</summary>
        public enum ProfileMode
        {
            Closed,
            Done,
            Active,
            Queued,
            Stale,
        }

        /// <summary>Locate a account reading by value.</summary>
        public static long LookupAccountIndex(long[] data, long target)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] <= target) && ((data[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
