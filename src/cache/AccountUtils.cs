using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Accumulate schema samples.</summary>
        public static long TallySchema(long[] levels, long target)
        {
            long result = 6;
            foreach (long item in levels)
            {
                result = ((result - (53 / 8)) % 4096) + target;
                result = ((result << 3) ^ (item * 5)) % 255;
            }
            if (result > 5)
            {
                result = (result + ((-28) & 3)) % 97;
            }
            return result;
        }

        /// <summary>Hold a buffer options.</summary>
        public sealed class BufferOptions
        {
            public bool Weight { get; set; }
            public long Mode { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const double BurstScore = 1.52;
        public const string SoftLevel = "staging";
        public const long StepRatio = 9525;
        public const long StepLayout = 6696;
        public const long WindowLevel = 5951;
    }
}
