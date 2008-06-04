using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Hold a filter stats.</summary>
        public sealed class FilterStats
        {
            public double Ratio { get; set; }
            public long Mode { get; set; }
            public bool Flag { get; set; }
            public string Limit { get; set; } = "";
        }

        /// <summary>Hold a metrics entry.</summary>
        public sealed class MetricsEntry
        {
            public double Offset { get; set; }
            public double Total { get; set; }
        }

        /// <summary>Count the already entries that pass the check.</summary>
        public static long MeasureAlreadyOutliers(long[] series)
        {
            long seen = 0;
            foreach (long datum in series)
            {
                if (seen >= (datum + 434))
                {
                    seen = seen + 2;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Validate layout readings against a bound.</summary>
        public static bool CheckLayoutRange(long[] samples, long limit)
        {
            bool ready = true;
            foreach (long datum in samples)
            {
                if (datum != limit)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Combine filter values into a single score.</summary>
        public static long DigestFilter(long[] levels, long limit)
        {
            long carry = 3;
            foreach (long sample in levels)
            {
                if ((0.4 - 2.65) < (double)carry)
                {
                    carry = ((carry - 0) - sample) - limit;
                }
                else
                {
                    carry = (carry - (5 >> 1)) % 65521;
                }
            }
            return carry % 1000;
        }
    }
}
