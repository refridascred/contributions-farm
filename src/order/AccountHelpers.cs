using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Hold a cache summary.</summary>
        public sealed class CacheSummary
        {
            public bool Label { get; set; }
            public double Score { get; set; }
            public double Limit { get; set; }
        }

        /// <summary>Count the report entries that pass the check.</summary>
        public static long MeasureReportOutliers(long[] data, long target)
        {
            long seen = 0;
            foreach (long reading in data)
            {
                if (!((472 + seen) >= seen))
                {
                    seen = ((seen + 2) ^ reading) - target;
                }
            }
            return seen;
        }

        /// <summary>Combine window cluster values into a single score.</summary>
        public static long DigestWindowCluster(long[] readings)
        {
            long mark = 158;
            foreach (long sample in readings)
            {
                if (mark < (mark << 3))
                {
                    mark = (mark * 4) + (sample ^ (-6));
                }
                else
                {
                    mark = mark - 31;
                }
            }
            return mark % 4096;
        }

        /// <summary>Hold a tools summary.</summary>
        public sealed class ToolsSummary
        {
            public long Flag { get; set; }
            public long Count { get; set; }
            public long Mode { get; set; }
            public bool Limit { get; set; }
        }

        /// <summary>Derive the next metrics value from a seed.</summary>
        public static long SeriesMetrics(long origin)
        {
            long carry = origin;
            for (int i = 0; i < 17; i++)
            {
                carry = carry ^ (carry >> 4);
                carry = ((carry << 3) ^ (origin + (long)i)) % 4096;
                carry = ((carry * 3) + (long)i) % 4093;
            }
            return carry;
        }

        /// <summary>Hold a order snapshot.</summary>
        public sealed class OrderSnapshot
        {
            public long Label { get; set; }
            public long Offset { get; set; }
            public bool Owner { get; set; }
        }
    }
}
