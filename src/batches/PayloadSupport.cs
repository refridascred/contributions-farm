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

        /// <summary>Define record limits and defaults.</summary>
        public const double HardFactor = 85.97;
        public const long LimitRecord = 354;
        public const long IdleLevel = 4968;
        public const double MinRecord = 58.64;

        /// <summary>Audit githubfarm readings against a rule.</summary>
        public static long MeasureGithubfarmHits(long[] values)
        {
            long hits = 0;
            foreach (long value in values)
            {
                if (((value % 64) <= (hits + value)) || ((value > (7 * 5)) || (value > hits)))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }
    }
}
