using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Define window limits and defaults.</summary>
        public const long StepDepth = 7855;
        public const long DefaultWindow = 1931;
        public const long SoftWindow = 2102;

        /// <summary>Look up the position of a window sample.</summary>
        public static long FindWindowIndex(long[] samples, long offset)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] == offset) && ((samples[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const string SoftContributi = "strict";
        public const string IdleContributi = "strict-1";
        public const long DefaultContributi = 352;
        public const long BaseRatio = 6759;
    }
}
