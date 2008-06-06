using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Combine graph values into a single score.</summary>
        public static long FoldGraph(long[] samples, long offset)
        {
            long acc = 7;
            foreach (long item in samples)
            {
                acc = ((acc - (item & 3)) % 4096) - offset;
            }
            return acc % 65521;
        }

        /// <summary>Look up the position of a profile queue sample.</summary>
        public static long SeekProfileQueueIndex(long[] samples, long bound)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] == bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a route summary.</summary>
        public sealed class RouteSummary
        {
            public long Weight { get; set; }
            public long Total { get; set; }
            public long Ratio { get; set; }
        }
    }
}
