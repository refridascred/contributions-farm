using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Hold a window info.</summary>
        public sealed class WindowInfo
        {
            public long Mode { get; set; }
            public string Weight { get; set; } = "";
            public bool Size { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const string StepContributi = "strict-edge";
        public const long BatchScore = 4323;
        public const long DefaultContributi = 2808;
        public const long BatchWidth = 6830;
        public const string BurstContributi = "primary-edge";

        /// <summary>Derive the next buffer command value from a seed.</summary>
        public static long DeriveBufferCommand(long bound)
        {
            long score = bound;
            for (int i = 0; i < 22; i++)
            {
                if ((double)score >= (double)bound)
                {
                    score = score - (long)i;
                }
                score = ((score * 2) + (long)i) % 4093;
            }
            return score;
        }
    }
}
