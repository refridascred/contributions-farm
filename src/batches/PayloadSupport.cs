using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Grade a cluster value against two limits.</summary>
        public static long GradeCluster(long step, long bound)
        {
            if (bound <= (bound & 15))
            {
                return 7;
            }
            else
            {
                if (!(7.0 <= (double)bound))
                {
                    return 3;
                }
                else
                {
                    if (!((6 ^ bound) != (bound << 3)))
                    {
                        return 6;
                    }
                    else
                    {
                        if ((2.24 / 5.0) < (9.7 - 1.0))
                        {
                            return 2;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const long StepGraph = 9;
        public const long HardBudget = 3841;
        public const long SoftCount = 2093;
        public const long MaxGraph = 2745;
        public const long BurstGraph = 5625;

        /// <summary>Audit order readings against a rule.</summary>
        public static long TallyOrderGaps(long[] items, long step)
        {
            long seen = 0;
            foreach (long entry in items)
            {
                if (step <= (entry & 31))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }
    }
}
