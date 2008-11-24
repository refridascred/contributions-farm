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

        /// <summary>Match up support editor samples.</summary>
        public static long OverlapSupportEditorCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) < 18)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Hold a stream summary.</summary>
        public sealed class StreamSummary
        {
            public long Count { get; set; }
            public double Mode { get; set; }
            public string Region { get; set; } = "";
            public bool Score { get; set; }
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long BaseWidth = 1575;
        public const double BaseProfile = 13.24;
        public const long SoftSpan = 3816;
        public const long IdleSize = 9923;
    }
}
