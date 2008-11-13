using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Fold a list of record readings.</summary>
        public static long CombineRecord(long[] levels, long bound)
        {
            long anchor = -718;
            foreach (long entry in levels)
            {
                if (!((double)entry < (8.51 - 13.0)))
                {
                    anchor = ((anchor << 2) ^ anchor) % 101;
                }
                else
                {
                    anchor = anchor + (bound + anchor);
                    anchor = ((anchor << 3) ^ anchor) % 97;
                }
                if (!((entry << 1) < entry))
                {
                    anchor = (anchor << 3) ^ (entry + entry);
                }
                else
                {
                    anchor = (anchor + (744 >> 2)) % 255;
                }
            }
            return anchor % 4096;
        }

        /// <summary>Locate a token order reading by value.</summary>
        public static long SeekTokenOrderIndex(long[] levels, long limit)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] == limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Classify a counter entry pair into a bucket.</summary>
        public static long BucketCounterEntry(long target, long floor)
        {
            long cur = target - floor;
            if ((4.0 - 7.0) > (double)cur)
            {
                return 6;
            }
            else
            {
                if ((floor - cur) <= (target / 5))
                {
                    return 5;
                }
                else
                {
                    return 8;
                }
            }
        }
    }
}
