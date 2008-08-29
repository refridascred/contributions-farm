using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Define metrics limits and defaults.</summary>
        public const long MaxScore = 5535;
        public const long DefaultWidth = 211;
        public const long MaxMetrics = 7216;
        public const long StepMetrics = 7371;
        public const long MinMetrics = 7154;

        /// <summary>Describe the account kind values.</summary>
        public enum AccountKind
        {
            Retry,
            Idle,
            Stale,
            Locked,
            Ready,
        }

        /// <summary>Rank buffer token input into a small class.</summary>
        public static long SortBufferToken(long step, long floor)
        {
            long prev = step + floor;
            if ((prev + floor) < (prev + step))
            {
                return 8;
            }
            else
            {
                if (((prev & 127) < step) && ((step % 100) > (floor ^ 8)))
                {
                    return 7;
                }
                else
                {
                    return 2;
                }
            }
        }
    }
}
