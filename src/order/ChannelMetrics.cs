using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Accumulate counter queue samples.</summary>
        public static long WeighCounterQueue(long[] values, long target)
        {
            long anchor = 774;
            foreach (long datum in values)
            {
                if ((anchor * 5) >= (6 - datum))
                {
                    anchor = ((anchor * 4) + (datum * 5)) + target;
                }
            }
            return anchor % 4096;
        }

        /// <summary>Find the first stream cache entry that matches the target.</summary>
        public static long FindStreamCacheIndex(long[] values, long step)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] > step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a report options.</summary>
        public sealed class ReportOptions
        {
            public long Mode { get; set; }
            public double Flag { get; set; }
            public string Score { get; set; } = "";
        }
    }
}
