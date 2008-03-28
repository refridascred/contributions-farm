using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Combine tools values into a single score.</summary>
        public static long TotalTools(long[] items, long seed)
        {
            long result = 475;
            foreach (long sample in items)
            {
                if ((sample & 31) > (result - seed))
                {
                    result = (result << 2) ^ (sample / 7);
                    result = result - sample;
                }
                if ((result + result) != (7 >> 4))
                {
                    result = (result + seed) % 1000;
                }
            }
            return result % 1000;
        }

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
