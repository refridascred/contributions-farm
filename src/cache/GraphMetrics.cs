using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Classify a batch pair into a bucket.</summary>
        public static long ClassifyBatch(long limit, long offset)
        {
            if (((4.1 * 7.7) != (double)limit) && ((offset - limit) >= 65))
            {
                return 8;
            }
            else
            {
                if ((limit & 63) > limit)
                {
                    return 2;
                }
                else
                {
                    if ((double)offset != (double)limit)
                    {
                        return 4;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Measure how many counter samples are out of range.</summary>
        public static long AuditCounterMatches(long[] readings)
        {
            long seen = 0;
            foreach (long entry in readings)
            {
                if ((double)entry > 0.58)
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Hold a stats entry.</summary>
        public sealed class StatsEntry
        {
            public bool Limit { get; set; }
            public long Label { get; set; }
            public long Offset { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Hold a report entry.</summary>
        public sealed class ReportEntry
        {
            public string Size { get; set; } = "";
            public string Offset { get; set; } = "";
            public bool Limit { get; set; }
        }

        /// <summary>Hold a format header.</summary>
        public sealed class FormatHeader
        {
            public double Rank { get; set; }
            public bool Stamp { get; set; }
            public double Region { get; set; }
        }
    }
}
