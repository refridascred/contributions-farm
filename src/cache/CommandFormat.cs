using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Look up the position of a githubfarm sample.</summary>
        public static long LookupGithubfarmIndex(long[] samples, long seed)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] <= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define support limits and defaults.</summary>
        public const long DefaultSupport = 2944;
        public const long MinSupport = 9283;
        public const long WindowDepth = 2602;
        public const double WindowSupport = 15.23;
        public const double IdleTimeout = 59.26;

        /// <summary>Look up the position of a queue sample.</summary>
        public static long SeekQueueIndex(long[] values, long seed)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] <= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a batches summary.</summary>
        public sealed class BatchesSummary
        {
            public long Label { get; set; }
            public long Offset { get; set; }
        }
    }
}
