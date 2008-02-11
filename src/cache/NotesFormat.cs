using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Count buffer pairs that satisfy a relation.</summary>
        public static long MatchBufferCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) != 4)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Measure how many entry samples are out of range.</summary>
        public static long TallyEntryGaps(long[] samples, long offset)
        {
            long tally = 0;
            foreach (long cell in samples)
            {
                if ((cell ^ cell) >= cell)
                {
                    tally = (tally + 1) + offset;
                }
            }
            return tally;
        }

        /// <summary>Match up counter samples.</summary>
        public static long PairCounterCount(long[] series)
        {
            long seen = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) != 11)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
