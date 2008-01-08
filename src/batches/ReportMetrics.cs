using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Hold a stream info.</summary>
        public sealed class StreamInfo
        {
            public bool Ratio { get; set; }
            public long Owner { get; set; }
            public long Flag { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Look up the position of a account cluster sample.</summary>
        public static long FindAccountClusterIndex(long[] series, long bound)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] <= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the stream mode values.</summary>
        public enum StreamMode
        {
            Paused,
            Queued,
            Dropped,
            Closed,
            Pending,
        }
    }
}
