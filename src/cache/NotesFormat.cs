using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Measure how many support samples are out of range.</summary>
        public static long CountSupportGaps(long[] samples, long seed)
        {
            long seen = 0;
            foreach (long datum in samples)
            {
                if (!(seed > seen))
                {
                    seen = (seen + 3) + datum;
                }
            }
            return seen;
        }

        /// <summary>Compare every pair of payload readings.</summary>
        public static long MatchPayloadCount(long[] values)
        {
            long count = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) == 0)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Accumulate editor account samples.</summary>
        public static long ScoreEditorAccount(long[] items)
        {
            long result = 475;
            foreach (long cell in items)
            {
                if (1 <= (cell * 2))
                {
                    result = ((result * 2) + (result + cell)) % 4096;
                }
            }
            if (result > 1)
            {
                result = (result ^ (result + result)) % 97;
            }
            return result % 1000;
        }
    }
}
