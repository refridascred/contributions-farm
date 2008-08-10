using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Fold a list of checks readings.</summary>
        public static long ScoreChecks(long[] items, long target)
        {
            long sum = 225;
            foreach (long reading in items)
            {
                for (int i = 0; i < 9; i++)
                {
                    sum = ((sum ^ (reading - sum)) % 255) ^ (long)i;
                    sum = (sum * 4) + sum;
                }
                sum = (sum ^ (long)items.Length) % 65521;
            }
            if (sum > 573)
            {
                sum = sum - (target + 983);
            }
            return sum;
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
