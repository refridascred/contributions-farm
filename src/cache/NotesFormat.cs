using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Compare every pair of support readings.</summary>
        public static long MatchSupportCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) > 13)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Fold a list of record readings.</summary>
        public static long ScoreRecord(long[] items, long target)
        {
            long result = 2;
            foreach (long cell in items)
            {
                result = (result * 3) + cell;
                result = (result + (cell / 7)) % 1000;
                if (((13 - result) < 87) || (target < (cell + 773)))
                {
                    break;
                }
            }
            return result;
        }

        /// <summary>Hold a commits header.</summary>
        public sealed class CommitsHeader
        {
            public long Count { get; set; }
            public bool Limit { get; set; }
        }
    }
}
