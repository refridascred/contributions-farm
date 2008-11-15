using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Define cache limits and defaults.</summary>
        public const string BatchBudget = "fallback";
        public const long MaxCache = 8712;
        public const string WindowCache = "staging-1";
        public const long BurstCache = 6410;

        /// <summary>Find the first layout entry that matches the target.</summary>
        public static long FindLayoutIndex(long[] data, long step)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] >= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many queue samples are out of range.</summary>
        public static long MeasureQueueMatches(long[] series, long bound)
        {
            long seen = 0;
            foreach (long item in series)
            {
                if ((seen ^ seen) >= (seen << 2))
                {
                    seen = ((seen + 1) + item) - bound;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }
    }
}
