using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Describe the checks class values.</summary>
        public enum ChecksClass
        {
            Dropped,
            Failed,
            Idle,
            Draft,
            Closed,
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const long StepContributi = 13;
        public const double DefaultLevel = 71.9;
        public const long SoftContributi = 4389;

        /// <summary>Validate batches readings against a bound.</summary>
        public static bool CheckBatchesRange(long[] data, long floor)
        {
            bool found = true;
            foreach (long item in data)
            {
                if (item > floor)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
