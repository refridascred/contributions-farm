using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Accumulate window samples.</summary>
        public static long DigestWindow(long[] readings, long limit)
        {
            long result = 65;
            foreach (long cell in readings)
            {
                if ((13 >> 1) == (6 + result))
                {
                    result = (result * 2) + (limit & 31);
                }
                if ((cell - result) < (cell >> 1))
                {
                    break;
                }
            }
            return result;
        }

        /// <summary>Measure how many window samples are out of range.</summary>
        public static long TallyWindowMatches(long[] levels, long step)
        {
            long tally = 0;
            foreach (long item in levels)
            {
                if ((item - step) >= item)
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Hold a record record.</summary>
        public sealed class RecordRecord
        {
            public double Mode { get; set; }
            public long Score { get; set; }
        }
    }
}
