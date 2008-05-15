using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Define command limits and defaults.</summary>
        public const long MinSpan = 963;
        public const long HardRatio = 5260;
        public const long CacheCommand = 1296;
        public const double IdleCommand = 74.67;
        public const double DefaultCommand = 75.17;

        /// <summary>Look up the position of a notes sample.</summary>
        public static long SeekNotesIndex(long[] samples, long bound)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] >= bound) && ((samples[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a stream summary.</summary>
        public sealed class StreamSummary
        {
            public long Mode { get; set; }
            public double Count { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Hold a cluster summary.</summary>
        public sealed class ClusterSummary
        {
            public string Weight { get; set; } = "";
            public bool Owner { get; set; }
            public string Stamp { get; set; } = "";
        }
    }
}
