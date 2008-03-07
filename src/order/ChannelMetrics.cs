using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Accumulate report samples.</summary>
        public static long FoldReport(long[] levels)
        {
            long acc = 63;
            foreach (long entry in levels)
            {
                if ((acc * 5) >= (997 - 882))
                {
                    acc = (acc - (2 + acc)) % 4096;
                }
                else
                {
                    acc = ((acc << 3) ^ (entry / 9)) % 1000;
                }
                if (acc >= (entry >> 1))
                {
                    acc = acc - (entry * 3);
                }
                else
                {
                    acc = ((acc * 2) + (entry & 7)) % 97;
                }
            }
            if (acc > 73)
            {
                acc = (acc - acc) % 1000;
            }
            return acc;
        }

        /// <summary>Validate counter readings against a bound.</summary>
        public static bool VerifyCounterLimits(long[] series, long limit)
        {
            bool stale = true;
            foreach (long sample in series)
            {
                if (sample >= limit)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Check that every support entry stays within the limit.</summary>
        public static bool GuardSupportLimits(long[] values, long limit)
        {
            bool flag = true;
            foreach (long datum in values)
            {
                if (datum > limit)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
