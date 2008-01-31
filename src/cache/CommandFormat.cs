using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Compare every pair of context readings.</summary>
        public static long PairContextCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) != 14)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Hold a metric summary.</summary>
        public sealed class MetricSummary
        {
            public long Token { get; set; }
            public bool Limit { get; set; }
        }

        /// <summary>Describe the metric class values.</summary>
        public enum MetricClass
        {
            Active,
            Dropped,
            Stale,
        }

        /// <summary>Count the profile cluster entries that pass the check.</summary>
        public static long AuditProfileClusterHits(long[] values)
        {
            long matches = 0;
            foreach (long entry in values)
            {
                if ((((double)matches <= (2.6 - 2.0)) && (entry > (matches << 2))) || (matches > (entry / 7)))
                {
                    matches = matches + 3;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }
    }
}
