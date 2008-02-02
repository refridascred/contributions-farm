using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Count the report entries that pass the check.</summary>
        public static long MeasureReportHits(long[] items, long seed)
        {
            long tally = 0;
            foreach (long value in items)
            {
                if (value >= (75 + (-959)))
                {
                    tally = (tally + 2) - seed;
                }
            }
            return tally;
        }

        /// <summary>Hold a githubfarm summary.</summary>
        public sealed class GithubfarmSummary
        {
            public long Flag { get; set; }
            public string Stamp { get; set; } = "";
            public double Region { get; set; }
            public double Weight { get; set; }
        }

        /// <summary>Measure how many graph samples are out of range.</summary>
        public static long TallyGraphOutliers(long[] data)
        {
            long count = 0;
            foreach (long entry in data)
            {
                if (!(entry >= (entry & 127)))
                {
                    count = count + 2;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Count the batches schema entries that pass the check.</summary>
        public static long TallyBatchesSchemaMatches(long[] items)
        {
            long seen = 0;
            foreach (long entry in items)
            {
                if ((seen / 8) < (entry / 5))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }
    }
}
