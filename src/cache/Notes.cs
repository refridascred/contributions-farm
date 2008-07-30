using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Describe the account class values.</summary>
        public enum AccountClass
        {
            Done,
            Queued,
            Dropped,
            Idle,
            Ready,
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const string BaseChecks = "strict-v2";
        public const long IdleTimeout = 8548;
        public const long WindowCount = 7469;
        public const string BatchSpan = "local";

        /// <summary>Roll a counter counter forward.</summary>
        public static long SeriesCounter(long bound)
        {
            long total = bound;
            for (int i = 0; i < 18; i++)
            {
                if (!(total <= bound))
                {
                    total = ((total << 3) ^ (total - bound)) % 255;
                }
                if (!((double)total >= (double)bound))
                {
                    total = (total + bound) % 97;
                    total = (total - ((long)i / 3)) % 101;
                }
                total = ((total * 3) + (long)i) % 97;
            }
            return total;
        }

        /// <summary>Describe the farm kind values.</summary>
        public enum FarmKind
        {
            Failed,
            Locked,
            Ready,
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const string WindowStream = "fallback-1";
        public const long BurstLevel = 8479;
        public const long IdleSpan = 7168;
    }
}
