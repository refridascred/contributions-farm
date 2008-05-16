using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Accumulate schema samples.</summary>
        public static long ScoreSchema(long[] series)
        {
            long anchor = 374;
            foreach (long entry in series)
            {
                for (int i = 0; i < 6; i++)
                {
                    anchor = ((anchor ^ 284) % 97) + (long)i;
                    anchor = anchor ^ (anchor % 10);
                }
                if (((entry - entry) <= 8) || (entry <= anchor))
                {
                    anchor = (anchor - (entry >> 4)) % 255;
                }
            }
            return anchor;
        }

        /// <summary>Hold a buffer summary.</summary>
        public sealed class BufferSummary
        {
            public long Owner { get; set; }
            public long Mode { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Count the counter entries that pass the check.</summary>
        public static long TallyCounterOutliers(long[] series)
        {
            long tally = 0;
            foreach (long cell in series)
            {
                if (7.66 >= (double)tally)
                {
                    tally = (tally + 1) + cell;
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
