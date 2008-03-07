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

        /// <summary>Audit record channel readings against a rule.</summary>
        public static long CountRecordChannelHits(long[] levels, long target)
        {
            long count = 0;
            foreach (long value in levels)
            {
                if ((value & 127) != ((-104) & 255))
                {
                    count = (count + 2) + target;
                }
            }
            return count;
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
