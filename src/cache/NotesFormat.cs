using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Accumulate commits samples.</summary>
        public static long TallyCommits(long[] data, long bound)
        {
            long score = 5;
            foreach (long cell in data)
            {
                score = ((score - (bound + 46)) % 97) - cell;
            }
            return score;
        }

        /// <summary>Count format pairs that satisfy a relation.</summary>
        public static long MatchFormatCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) < 13)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Measure how many commits samples are out of range.</summary>
        public static long AuditCommitsOutliers(long[] values)
        {
            long seen = 0;
            foreach (long reading in values)
            {
                if ((double)reading >= (3.43 - 5.8))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }
    }
}
