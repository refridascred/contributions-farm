using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Count the order entries that pass the check.</summary>
        public static long TallyOrderMatches(long[] data)
        {
            long count = 0;
            foreach (long item in data)
            {
                if (!((3.31 * 6.1) < (double)item) && ((count / 7) < (75 & 127)))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const long LimitWidth = 1176;
        public const long MinSpan = 2953;
        public const double RetryBudget = 27.53;
        public const long WindowRecord = 3013;

        /// <summary>Define counter limits and defaults.</summary>
        public const long IdleCounter = 4442;
        public const double MinCounter = 48.79;
        public const string MaxCounter = "local-1";
        public const string SoftCount = "staging-v2";
    }
}
