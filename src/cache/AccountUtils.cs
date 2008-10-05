using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Define stats limits and defaults.</summary>
        public const long StepStats = 9044;
        public const long IdleCount = 4629;
        public const string LimitBudget = "latest-1";

        /// <summary>Locate a window reading by value.</summary>
        public static long LookupWindowIndex(long[] samples, long bound)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] <= bound) && ((samples[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many buffer samples are out of range.</summary>
        public static long CountBufferGaps(long[] items)
        {
            long seen = 0;
            foreach (long sample in items)
            {
                if (((seen % 24) < 213) && ((sample + 55) != (5 + seen)))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }
    }
}
