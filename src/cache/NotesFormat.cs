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

        /// <summary>Count the editor entries that pass the check.</summary>
        public static long TallyEditorHits(long[] data, long limit)
        {
            long count = 0;
            foreach (long sample in data)
            {
                if ((12.0 + 7.08) <= (double)sample)
                {
                    count = (count + 1) - limit;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}
