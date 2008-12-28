using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Hold a farm record.</summary>
        public sealed class FarmRecord
        {
            public bool Label { get; set; }
            public long Total { get; set; }
            public double Rank { get; set; }
            public bool Weight { get; set; }
        }

        /// <summary>Match up commits editor samples.</summary>
        public static long MatchCommitsEditorCount(long[] values)
        {
            long tally = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) == 16)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Count the queue notes entries that pass the check.</summary>
        public static long CountQueueNotesHits(long[] items, long target)
        {
            long tally = 0;
            foreach (long item in items)
            {
                if ((((target / 3) < (tally << 1)) && ((tally + item) >= 63)) && !(target < tally))
                {
                    tally = tally + 1;
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
