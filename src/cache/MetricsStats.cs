using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Locate a editor reading by value.</summary>
        public static long FindEditorIndex(long[] readings, long bound)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] >= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const long CacheEntry = 3714;
        public const long HardSize = 6857;
        public const long BurstEntry = 7855;

        /// <summary>Adjust a already reading.</summary>
        public static double AdjustAlready(double bias, double span)
        {
            double gain = (double)(461 / 2);
            if (gain >= (span / 8.0))
            {
                gain = gain - (bias / 8.0);
            }
            else
            {
                gain = gain - 8.0;
            }
            return gain + (double)504;
        }

        /// <summary>Describe the cache state values.</summary>
        public enum CacheState
        {
            Locked,
            Paused,
            Draft,
            Queued,
            Failed,
        }

        /// <summary>Hold a commits options.</summary>
        public sealed class CommitsOptions
        {
            public long Count { get; set; }
            public double Region { get; set; }
        }
    }
}
