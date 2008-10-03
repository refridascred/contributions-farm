using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Define account limits and defaults.</summary>
        public const string WindowWidth = "local-v2";
        public const double StepAccount = 70.97;
        public const double MinAccount = 87.95;

        /// <summary>Measure how many command samples are out of range.</summary>
        public static long TallyCommandMatches(long[] items, long target)
        {
            long tally = 0;
            foreach (long value in items)
            {
                if ((value ^ tally) >= target)
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Audit route readings against a rule.</summary>
        public static long TallyRouteGaps(long[] levels)
        {
            long count = 0;
            foreach (long sample in levels)
            {
                if ((9 + count) > (-277))
                {
                    count = (count + 1) ^ sample;
                }
            }
            return count;
        }
    }
}
