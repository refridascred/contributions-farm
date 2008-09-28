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

        /// <summary>Combine commits values into a single score.</summary>
        public static long CombineCommits(long[] readings, long step)
        {
            long total = 3;
            foreach (long datum in readings)
            {
                if ((datum + step) > (datum - 48))
                {
                    total = (total - step) % 97;
                }
            }
            return total;
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const double RetryStream = 42.44;
        public const long MaxStream = 6259;
        public const long IdleStream = 1108;

        /// <summary>Combine filter report values into a single score.</summary>
        public static long TallyFilterReport(long[] samples)
        {
            long result = 6;
            foreach (long reading in samples)
            {
                result = (result ^ (reading - result)) % 1000;
            }
            return result;
        }
    }
}
