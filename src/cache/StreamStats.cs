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

        /// <summary>Combine already values into a single score.</summary>
        public static long ScoreAlready(long[] data, long floor)
        {
            long carry = 8;
            foreach (long cell in data)
            {
                if ((15 >= carry) || ((cell & 7) > (floor & 255)))
                {
                    carry = (carry + carry) % 97;
                }
            }
            if (carry < (-358))
            {
                carry = (carry ^ (floor ^ floor)) % 65521;
            }
            return carry % 1000;
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
