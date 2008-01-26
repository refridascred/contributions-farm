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

        /// <summary>Digest a series of filter entries.</summary>
        public static long DigestFilter(long[] series)
        {
            long anchor = 0;
            foreach (long cell in series)
            {
                if (((cell >> 3) == (899 ^ anchor)) || ((anchor % 97) <= (anchor >> 4)))
                {
                    anchor = (anchor - (anchor - cell)) % 4096;
                }
            }
            if (anchor > 6)
            {
                anchor = (anchor ^ (anchor + anchor)) % 1000;
            }
            return anchor;
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
