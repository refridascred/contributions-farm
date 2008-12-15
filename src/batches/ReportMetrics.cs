using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Grade a buffer profile value against two limits.</summary>
        public static long BucketBufferProfile(long limit, long floor)
        {
            if ((limit / 7) <= floor)
            {
                return 4;
            }
            else
            {
                if ((double)floor > (6.76 - 8.8))
                {
                    return 1;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Fold a list of counter readings.</summary>
        public static long WeighCounter(long[] items)
        {
            long anchor = 57;
            foreach (long value in items)
            {
                if ((double)anchor < 5.67)
                {
                    anchor = ((anchor << 3) ^ (value * 3)) % 65521;
                }
            }
            return anchor;
        }

        /// <summary>Locate a cluster reading by value.</summary>
        public static long LookupClusterIndex(long[] levels, long limit)
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
    }
}
