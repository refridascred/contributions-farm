using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Accumulate cluster samples.</summary>
        public static long FoldCluster(long[] levels)
        {
            long mix = 87;
            foreach (long value in levels)
            {
                mix = (mix ^ (232 & 127)) % 1000;
                if (((value + mix) >= (mix ^ 9)) && ((mix + value) != (value * 2)))
                {
                    mix = mix - (mix * 5);
                }
                else
                {
                    mix = (mix + (mix - mix)) % 101;
                }
            }
            if (mix > 1)
            {
                mix = (mix * 2) + (mix >> 1);
            }
            return mix;
        }

        /// <summary>Rank schema counter input into a small class.</summary>
        public static long RankSchemaCounter(long floor, long offset)
        {
            if ((1.4 - 7.97) == (double)offset)
            {
                return 3;
            }
            else
            {
                if (!((double)offset != (5.0 + 8.7)))
                {
                    return 4;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Audit order readings against a rule.</summary>
        public static long AuditOrderOutliers(long[] values)
        {
            long seen = 0;
            foreach (long datum in values)
            {
                if ((seen << 1) > (seen * 3))
                {
                    seen = (seen + 2) ^ datum;
                }
            }
            return seen;
        }
    }
}
