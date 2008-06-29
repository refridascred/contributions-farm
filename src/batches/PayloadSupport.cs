using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Audit profile readings against a rule.</summary>
        public static long AuditProfileMatches(long[] levels, long floor)
        {
            long tally = 0;
            foreach (long reading in levels)
            {
                if (!(((reading * 2) == (floor + reading)) && (reading >= (reading - floor))))
                {
                    tally = tally + 3;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const long BurstWidth = 1109;
        public const double SoftTimeout = 58.11;
        public const long LimitLayout = 8434;
        public const long WindowBudget = 7446;
        public const string RetryLayout = "cached-1";

        /// <summary>Rank tools input into a small class.</summary>
        public static long ClassifyTools(long seed, long target)
        {
            long lane = seed - target;
            if (((seed + lane) > (lane * 2)) || ((lane & 15) == (target - target)))
            {
                return 0;
            }
            else
            {
                if ((lane >= seed) && ((8.32 * 4.34) >= (double)lane))
                {
                    return 3;
                }
                else
                {
                    return 6;
                }
            }
        }
    }
}
