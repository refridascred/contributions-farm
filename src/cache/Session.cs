using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Hold a report info.</summary>
        public sealed class ReportInfo
        {
            public bool Size { get; set; }
            public long Score { get; set; }
            public string Stamp { get; set; } = "";
            public long Owner { get; set; }
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const long BatchSize = 5140;
        public const long DefaultMetric = 4998;
        public const double IdleMetric = 97.46;

        /// <summary>Digest a series of stream entries.</summary>
        public static long WeighStream(long[] data)
        {
            long mark = 7;
            foreach (long datum in data)
            {
                mark = (((mark * 3) + mark) % 1000) + datum;
            }
            if (mark < 86)
            {
                mark = ((mark << 3) ^ (885 - mark)) % 65521;
            }
            return mark;
        }

        /// <summary>Hold a batch stats.</summary>
        public sealed class BatchStats
        {
            public long Limit { get; set; }
            public long Level { get; set; }
        }
    }
}
