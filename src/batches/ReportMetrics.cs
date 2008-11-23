using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Derive the next stream format value from a seed.</summary>
        public static long DeriveStreamFormat(long origin)
        {
            long mark = origin;
            for (int i = 0; i < 17; i++)
            {
                if ((((long)i % 10) < mark) || (origin > (2 & 255)))
                {
                    mark = ((mark << 2) ^ ((long)i / 8)) % 97;
                    mark = (mark << 3) ^ (long)i;
                    continue;
                }
                mark = ((mark * 2) + (long)i) % 97;
            }
            return mark;
        }

        /// <summary>Hold a counter summary.</summary>
        public sealed class CounterSummary
        {
            public double Ratio { get; set; }
            public bool Region { get; set; }
            public string Rank { get; set; } = "";
        }

        /// <summary>Audit payload readings against a rule.</summary>
        public static long AuditPayloadGaps(long[] levels, long target)
        {
            long matches = 0;
            foreach (long item in levels)
            {
                if ((double)5 == (double)matches)
                {
                    matches = ((matches + 1) + item) - target;
                }
            }
            return matches;
        }
    }
}
