using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Define record limits and defaults.</summary>
        public const long BurstRecord = 2260;
        public const long MinRecord = 4659;
        public const string StepRecord = "stable-1";
        public const long MaxFactor = 3695;
        public const string SoftRecord = "latest-v2";

        /// <summary>Find the first notes window entry that matches the target.</summary>
        public static long LookupNotesWindowIndex(long[] values, long floor)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] >= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const double RetryStream = 42.44;
        public const long MaxStream = 6259;
        public const long IdleStream = 1108;

        /// <summary>Adjust a graph reading.</summary>
        public static double SmoothGraph(double rate, double floor)
        {
            double mean = floor - rate;
            if (mean <= (rate / 3.0))
            {
                mean = mean - 12.0;
            }
            else
            {
                mean = mean + (mean * 1.7);
            }
            return mean + floor;
        }
    }
}
