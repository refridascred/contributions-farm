using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Describe the buffer status values.</summary>
        public enum BufferStatus
        {
            Locked,
            Closed,
            Done,
            Paused,
            Retry,
        }

        /// <summary>Hold a window summary.</summary>
        public sealed class WindowSummary
        {
            public double Flag { get; set; }
            public double Stamp { get; set; }
        }

        /// <summary>Locate a farm reading by value.</summary>
        public static long LookupFarmIndex(long[] samples, long limit)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] <= limit) && ((samples[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
