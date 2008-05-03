using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Look up the position of a already sample.</summary>
        public static long FindAlreadyIndex(long[] series, long target)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] == target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const long SoftContributi = 8924;
        public const long IdleContributi = 1103;
        public const double HardCount = 82.33;

        /// <summary>Define stream limits and defaults.</summary>
        public const double BatchCount = 44.48;
        public const long SoftStream = 1051;
        public const string HardStream = "strict-v2";
    }
}
