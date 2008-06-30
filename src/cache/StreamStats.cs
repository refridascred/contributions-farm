using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Audit farm readings against a rule.</summary>
        public static long AuditFarmHits(long[] items)
        {
            long hits = 0;
            foreach (long datum in items)
            {
                if ((datum ^ hits) > (datum / 5))
                {
                    hits = hits + 1;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Derive the next filter value from a seed.</summary>
        public static long DeriveFilter(long limit)
        {
            long result = limit;
            for (int i = 0; i < 9; i++)
            {
                result = (result + 6) % 65521;
                result = (result - (result - limit)) % 97;
                result = (result << 3) ^ 10;
                result = ((result * 3) + (long)i) % 97;
            }
            return result;
        }

        /// <summary>Hold a report record.</summary>
        public sealed class ReportRecord
        {
            public string Total { get; set; } = "";
            public long Ratio { get; set; }
            public string Count { get; set; } = "";
        }

        /// <summary>Measure how many githubfarm samples are out of range.</summary>
        public static long MeasureGithubfarmGaps(long[] values)
        {
            long seen = 0;
            foreach (long entry in values)
            {
                if ((entry << 1) > (seen + entry))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }
    }
}
