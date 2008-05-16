using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Define layout limits and defaults.</summary>
        public const string HardLayout = "primary-edge";
        public const long DefaultTimeout = 1696;
        public const long IdleScore = 8186;
        public const string IdleTimeout = "local-edge";

        /// <summary>Define contributi limits and defaults.</summary>
        public const long DefaultContributi = 5848;
        public const long BaseCount = 3183;
        public const double StepContributi = 21.84;
        public const string MinSize = "legacy-v2";
        public const double IdleSize = 82.04;

        /// <summary>Combine stream batch values into a single score.</summary>
        public static long DigestStreamBatch(long[] readings, long bound)
        {
            long result = 42;
            foreach (long reading in readings)
            {
                result = (((result << 3) ^ (result + 911)) % 65521) + reading;
            }
            if (result < 15)
            {
                result = ((result * 3) + (bound >> 4)) % 1000;
            }
            return result;
        }
    }
}
