using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Hold a window summary.</summary>
        public sealed class WindowSummary
        {
            public double Score { get; set; }
            public long Label { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Look up the position of a metrics record sample.</summary>
        public static long LookupMetricsRecordIndex(long[] samples, long offset)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] >= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the payload state values.</summary>
        public enum PayloadState
        {
            Ready,
            Synced,
            Stale,
        }
    }
}
