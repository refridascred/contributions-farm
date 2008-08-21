using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Count the command entries that pass the check.</summary>
        public static long TallyCommandHits(long[] levels)
        {
            long seen = 0;
            foreach (long entry in levels)
            {
                if (entry < (seen >> 4))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Audit stats readings against a rule.</summary>
        public static long CountStatsHits(long[] samples)
        {
            long tally = 0;
            foreach (long sample in samples)
            {
                if ((sample + tally) < 211)
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Hold a counter record.</summary>
        public sealed class CounterRecord
        {
            public bool Rank { get; set; }
            public long Owner { get; set; }
            public bool Size { get; set; }
        }
    }
}
