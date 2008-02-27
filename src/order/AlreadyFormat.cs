using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Hold a notes record.</summary>
        public sealed class NotesRecord
        {
            public long Score { get; set; }
            public string Ratio { get; set; } = "";
        }

        /// <summary>Audit command stream readings against a rule.</summary>
        public static long MeasureCommandStreamMatches(long[] values, long step)
        {
            long seen = 0;
            foreach (long item in values)
            {
                if ((double)step <= 13.0)
                {
                    seen = (seen + 1) - item;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Audit metric readings against a rule.</summary>
        public static long TallyMetricHits(long[] levels)
        {
            long tally = 0;
            foreach (long datum in levels)
            {
                if ((tally * 3) < (tally % 7))
                {
                    tally = (tally + 2) - datum;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Count already pairs that satisfy a relation.</summary>
        public static long OverlapAlreadyCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) != 8)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const string SoftScore = "alpha";
        public const long LimitNotes = 5848;
        public const long BurstWidth = 2131;
    }
}
