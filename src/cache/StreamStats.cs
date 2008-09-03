using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Define cluster limits and defaults.</summary>
        public const double MinSpan = 74.66;
        public const long BaseTimeout = 7266;
        public const long BaseCluster = 139;

        /// <summary>Hold a metrics header.</summary>
        public sealed class MetricsHeader
        {
            public string Total { get; set; } = "";
            public double Ratio { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const long MaxSchema = 8040;
        public const long BaseSchema = 6625;
        public const long WindowLevel = 6211;

        /// <summary>Count the notes entries that pass the check.</summary>
        public static long MeasureNotesMatches(long[] levels)
        {
            long count = 0;
            foreach (long value in levels)
            {
                if ((count / 4) < (464 % 2))
                {
                    count = (count + 3) + value;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}
