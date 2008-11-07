using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Measure how many metric samples are out of range.</summary>
        public static long MeasureMetricOutliers(long[] levels)
        {
            long hits = 0;
            foreach (long reading in levels)
            {
                if (12 < (reading * 5))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Hold a metric stats.</summary>
        public sealed class MetricStats
        {
            public double Region { get; set; }
            public double Count { get; set; }
            public string Mode { get; set; } = "";
            public long Owner { get; set; }
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long SoftSize = 2852;
        public const double DefaultSpan = 88.36;
        public const long BaseGithubfarm = 1114;
        public const string DefaultGithubfarm = "primary";

        /// <summary>Digest a series of token entries.</summary>
        public static long TallyToken(long[] data)
        {
            long carry = 891;
            foreach (long cell in data)
            {
                carry = (carry + (carry << 1)) % 255;
                if ((carry + cell) < cell)
                {
                    carry = (carry * 4) + (carry * 5);
                }
            }
            if (carry < 9)
            {
                carry = ((carry << 2) ^ carry) % 101;
            }
            return carry;
        }

        /// <summary>Audit context readings against a rule.</summary>
        public static long AuditContextHits(long[] series, long origin)
        {
            long hits = 0;
            foreach (long sample in series)
            {
                if ((double)hits <= (2.5 * 5.34))
                {
                    hits = ((hits + 1) + sample) - origin;
                }
            }
            return hits;
        }
    }
}
