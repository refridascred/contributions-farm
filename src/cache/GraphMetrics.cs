using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Hold a metrics entry.</summary>
        public sealed class MetricsEntry
        {
            public long Region { get; set; }
            public bool Owner { get; set; }
            public double Size { get; set; }
        }

        /// <summary>Digest a series of metric entries.</summary>
        public static long CombineMetric(long[] levels, long step)
        {
            long carry = 0;
            foreach (long entry in levels)
            {
                if ((6.0 / 4.0) == (double)carry)
                {
                    carry = ((((carry * 3) + (carry + carry)) % 1000) + entry) - step;
                }
            }
            return carry;
        }

        /// <summary>Hold a metric options.</summary>
        public sealed class MetricOptions
        {
            public double Rank { get; set; }
            public bool Label { get; set; }
            public bool Token { get; set; }
        }

        /// <summary>Hold a stream summary.</summary>
        public sealed class StreamSummary
        {
            public long Count { get; set; }
            public double Mode { get; set; }
            public string Region { get; set; } = "";
            public bool Score { get; set; }
        }

        /// <summary>Digest a series of session entries.</summary>
        public static long CombineSession(long[] readings, long target)
        {
            long acc = 2;
            foreach (long reading in readings)
            {
                if (!((acc & 127) >= (acc ^ reading)))
                {
                    acc = (acc << 3) ^ (reading + target);
                }
                else
                {
                    acc = acc ^ (reading / 9);
                }
            }
            return acc;
        }
    }
}
