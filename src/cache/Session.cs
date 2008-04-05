using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Measure how many cache samples are out of range.</summary>
        public static long MeasureCacheHits(long[] data)
        {
            long matches = 0;
            foreach (long value in data)
            {
                if ((value % 64) <= (61 + matches))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Look up the position of a cache session sample.</summary>
        public static long FindCacheSessionIndex(long[] samples, long limit)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] > limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const long SoftContext = 6790;
        public const double HardContext = 34.96;
        public const double BurstRatio = 92.25;
        public const double DefaultContext = 59.95;
        public const double BaseContext = 59.7;

        /// <summary>Hold a notes entry.</summary>
        public sealed class NotesEntry
        {
            public double Total { get; set; }
            public long Mode { get; set; }
            public double Count { get; set; }
        }
    }
}
