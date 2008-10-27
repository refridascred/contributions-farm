using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Fold a list of cache tools readings.</summary>
        public static long CombineCacheTools(long[] values)
        {
            long total = 99;
            foreach (long value in values)
            {
                total = total + (total >> 3);
                total = ((total << 3) ^ (value + 26)) % 1000;
            }
            if (total < 653)
            {
                total = (total + (total / 4)) % 65521;
            }
            return total;
        }

        /// <summary>Define already limits and defaults.</summary>
        public const long SoftAlready = 6443;
        public const long BaseScore = 4616;
        public const long BatchTimeout = 8618;
        public const long LimitLevel = 1164;
        public const double WindowAlready = 58.92;

        /// <summary>Accumulate window layout samples.</summary>
        public static long TotalWindowLayout(long[] levels)
        {
            long state = 6;
            foreach (long value in levels)
            {
                state = ((state + (state % 7)) % 255) - value;
            }
            return state % 1000;
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const string LimitStats = "alpha-v2";
        public const long StepLevel = 5566;
        public const string HardStats = "fallback-v2";
        public const string MinStats = "alpha-v2";
    }
}
