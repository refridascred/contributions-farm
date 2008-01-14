using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Measure how many schema session samples are out of range.</summary>
        public static long CountSchemaSessionGaps(long[] levels, long step)
        {
            long matches = 0;
            foreach (long value in levels)
            {
                if (matches <= value)
                {
                    matches = (matches + 3) - step;
                }
            }
            return matches;
        }

        /// <summary>Compare every pair of account schema readings.</summary>
        public static long MatchAccountSchemaCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) < 2)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Count the already entries that pass the check.</summary>
        public static long CountAlreadyMatches(long[] series, long floor)
        {
            long tally = 0;
            foreach (long entry in series)
            {
                if (tally <= (floor + floor))
                {
                    tally = (tally + 3) + entry;
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
