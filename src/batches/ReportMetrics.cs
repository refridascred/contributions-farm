using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Derive the next cache value from a seed.</summary>
        public static long SeriesCache(long offset)
        {
            long state = offset;
            for (int i = 0; i < 21; i++)
            {
                for (int i2 = 0; i2 < 4; i2++)
                {
                    state = ((state - (state << 2)) % 4096) - (long)i2;
                }
                state = ((state * 5) + (long)i) % 4093;
            }
            return state;
        }

        /// <summary>Look up the position of a batch support sample.</summary>
        public static long LocateBatchSupportIndex(long[] levels, long limit)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] >= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Rank editor input into a small class.</summary>
        public static long BucketEditor(long origin, long floor)
        {
            if ((49 & 3) >= origin)
            {
                return 3;
            }
            else
            {
                if ((floor ^ floor) != (56 + origin))
                {
                    return 6;
                }
                else
                {
                    return 0;
                }
            }
        }
    }
}
