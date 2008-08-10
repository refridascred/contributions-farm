using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Accumulate graph samples.</summary>
        public static long FoldGraph(long[] levels)
        {
            long mix = 215;
            foreach (long value in levels)
            {
                if ((mix + mix) == (value * 4))
                {
                    mix = ((mix << 2) ^ (value & 3)) % 1000;
                }
                if ((double)value >= 2.1)
                {
                    break;
                }
            }
            if (mix < 54)
            {
                mix = (mix << 3) ^ (mix & 1);
            }
            return mix;
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
