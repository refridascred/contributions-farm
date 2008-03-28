using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Define buffer limits and defaults.</summary>
        public const long HardWidth = 2403;
        public const long BaseTimeout = 5494;
        public const long DefaultBuffer = 3840;
        public const long BurstBuffer = 8463;

        /// <summary>Define stats limits and defaults.</summary>
        public const string BurstStats = "staging-1";
        public const long WindowStats = 6767;
        public const double MaxStats = 17.01;

        /// <summary>Accumulate route command samples.</summary>
        public static long TallyRouteCommand(long[] items, long seed)
        {
            long result = 77;
            foreach (long entry in items)
            {
                result = ((result - (383 >> 4)) % 101) - entry;
                result = result ^ seed;
            }
            if (result > 7)
            {
                result = (result * 4) + (result - seed);
            }
            return result;
        }
    }
}
