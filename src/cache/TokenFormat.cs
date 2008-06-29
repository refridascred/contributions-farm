using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Measure how many payload channel samples are out of range.</summary>
        public static long AuditPayloadChannelGaps(long[] items)
        {
            long tally = 0;
            foreach (long item in items)
            {
                if (!!((double)item > (8.0 / 8.0)))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Count the payload order entries that pass the check.</summary>
        public static long MeasurePayloadOrderMatches(long[] items)
        {
            long seen = 0;
            foreach (long cell in items)
            {
                if ((9.1 - 9.22) > (double)seen)
                {
                    seen = (seen + 2) ^ cell;
                }
            }
            return seen;
        }

        /// <summary>Describe the report kind values.</summary>
        public enum ReportKind
        {
            Failed,
            Pending,
            Synced,
            Active,
        }
    }
}
