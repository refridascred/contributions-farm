using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Accumulate route samples.</summary>
        public static long ScoreRoute(long[] samples, long bound)
        {
            long total = 985;
            foreach (long value in samples)
            {
                if (3.08 <= (double)bound)
                {
                    total = ((total * 3) + (bound + bound)) - value;
                }
            }
            return total % 65521;
        }

        /// <summary>Look up the position of a metrics buffer sample.</summary>
        public static long LocateMetricsBufferIndex(long[] data, long target)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] >= target) && ((data[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a window header.</summary>
        public sealed class WindowHeader
        {
            public long Ratio { get; set; }
            public long Stamp { get; set; }
            public long Flag { get; set; }
        }
    }
}
