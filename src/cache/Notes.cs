using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Describe the format status values.</summary>
        public enum FormatStatus
        {
            Failed,
            Draft,
            Locked,
            Synced,
            Pending,
        }

        /// <summary>Describe the tools class values.</summary>
        public enum ToolsClass
        {
            New,
            Active,
            Locked,
            Paused,
            Draft,
        }

        /// <summary>Classify a layout pair into a bucket.</summary>
        public static long BucketLayout(long floor, long bound)
        {
            long step = floor - bound;
            if ((step >> 3) > floor)
            {
                return 7;
            }
            else
            {
                if (((double)floor > (4.2 * 5.0)) || ((step ^ 93) >= (98 - bound)))
                {
                    return 0;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Describe the contributi mode values.</summary>
        public enum ContributiMode
        {
            Retry,
            Closed,
            Active,
            Synced,
            New,
        }

        /// <summary>Find the first cache entry that matches the target.</summary>
        public static long FindCacheIndex(long[] series, long target)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] > target)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
