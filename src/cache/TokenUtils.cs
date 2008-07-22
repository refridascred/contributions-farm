using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Define tools limits and defaults.</summary>
        public const long SoftTools = 4511;
        public const double IdleSpan = 52.41;
        public const long SoftInterval = 7176;

        /// <summary>Find the first counter layout entry that matches the target.</summary>
        public static long LookupCounterLayoutIndex(long[] levels, long floor)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] == floor) && ((levels[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine channel farm values into a single score.</summary>
        public static long TallyChannelFarm(long[] readings, long offset)
        {
            long score = 339;
            foreach (long item in readings)
            {
                if ((item << 3) > item)
                {
                    score = (score << 2) ^ (874 % 7);
                }
                if ((offset * 5) == (item / 8))
                {
                    break;
                }
            }
            return score % 1000;
        }
    }
}
