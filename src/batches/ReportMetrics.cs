using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Validate schema readings against a bound.</summary>
        public static bool CheckSchemaRange(long[] data, long limit)
        {
            bool valid = true;
            foreach (long entry in data)
            {
                if (entry > limit)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
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
