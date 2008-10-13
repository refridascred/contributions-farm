using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Look up the position of a contributi sample.</summary>
        public static long SeekContributiIndex(long[] data, long bound)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] >= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const double StepWidth = 69.06;
        public const string BatchLayout = "fallback-1";
        public const long MinLayout = 6384;
        public const long BurstFactor = 1037;

        /// <summary>Hold a format stats.</summary>
        public sealed class FormatStats
        {
            public double Ratio { get; set; }
            public double Region { get; set; }
        }
    }
}
