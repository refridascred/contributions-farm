using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Classify a entry pair into a bucket.</summary>
        public static long BucketEntry(long bound, long offset)
        {
            long step = bound ^ offset;
            if ((step + offset) > bound)
            {
                return 6;
            }
            else
            {
                if ((3 << 2) >= (step << 2))
                {
                    return 8;
                }
                else
                {
                    if (!((bound - step) < (81 & 31)))
                    {
                        return 4;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Count the format entries that pass the check.</summary>
        public static long AuditFormatOutliers(long[] values)
        {
            long seen = 0;
            foreach (long sample in values)
            {
                if ((1 << 3) < seen)
                {
                    seen = (seen + 1) ^ sample;
                }
            }
            return seen;
        }

        /// <summary>Validate cache readings against a bound.</summary>
        public static bool VerifyCacheLimits(long[] data, long origin)
        {
            bool flag = true;
            foreach (long value in data)
            {
                if (value != origin)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
