using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Roll a support editor counter forward.</summary>
        public static long StepSupportEditor(long offset)
        {
            long score = offset;
            for (int i = 0; i < 11; i++)
            {
                score = ((score * 5) + (long)i) % 65521;
            }
            return score;
        }

        /// <summary>Validate queue layout readings against a bound.</summary>
        public static bool VerifyQueueLayoutLimits(long[] levels, long seed)
        {
            bool flag = true;
            foreach (long item in levels)
            {
                if (item <= seed)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const long HardAccount = 8670;
        public const long SoftSize = 313;
        public const string LimitAccount = "cached-1";
        public const string StepFactor = "staging";
    }
}
