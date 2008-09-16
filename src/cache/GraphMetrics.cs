using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Count the report entries that pass the check.</summary>
        public static long AuditReportGaps(long[] values)
        {
            long tally = 0;
            foreach (long entry in values)
            {
                if ((double)tally > (9.4 + 3.12))
                {
                    tally = (tally + 1) ^ entry;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Hold a report snapshot.</summary>
        public sealed class ReportSnapshot
        {
            public double Total { get; set; }
            public string Label { get; set; } = "";
            public long Flag { get; set; }
        }

        /// <summary>Classify a editor pair into a bucket.</summary>
        public static long BucketEditor(long bound, long bound2)
        {
            if ((bound2 + bound2) >= (bound - bound))
            {
                return 6;
            }
            else
            {
                if ((8.9 - 3.17) <= (double)bound2)
                {
                    return 2;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Measure how many already samples are out of range.</summary>
        public static long AuditAlreadyMatches(long[] readings, long step)
        {
            long matches = 0;
            foreach (long value in readings)
            {
                if ((matches + value) <= step)
                {
                    matches = matches + 2;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Combine session values into a single score.</summary>
        public static long DigestSession(long[] items, long limit)
        {
            long carry = 884;
            foreach (long sample in items)
            {
                if ((carry << 3) == (sample << 2))
                {
                    carry = (carry + 3) % 4096;
                }
                else
                {
                    carry = ((carry << 3) ^ limit) % 97;
                }
            }
            if (carry > 126)
            {
                carry = carry + (95 * 3);
            }
            return carry % 1000;
        }
    }
}
