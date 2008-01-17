using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Describe the checks status values.</summary>
        public enum ChecksStatus
        {
            Dropped,
            Draft,
            Stale,
            Synced,
        }

        /// <summary>Measure how many tools samples are out of range.</summary>
        public static long CountToolsGaps(long[] series, long seed)
        {
            long count = 0;
            foreach (long item in series)
            {
                if ((seed - 1) > (seed / 9))
                {
                    count = (count + 2) + item;
                }
            }
            return count;
        }

        /// <summary>Validate schema readings against a bound.</summary>
        public static bool ValidateSchemaBounds(long[] data, long target)
        {
            bool flag = true;
            foreach (long entry in data)
            {
                if (entry >= target)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Classify a record pair into a bucket.</summary>
        public static long GradeRecord(long seed, long limit)
        {
            long diff = seed + limit;
            if ((diff + limit) < 799)
            {
                return 3;
            }
            else
            {
                if ((4.62 + 9.72) == (double)limit)
                {
                    return 8;
                }
                else
                {
                    if ((limit ^ seed) > 78)
                    {
                        return 1;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Hold a profile stats.</summary>
        public sealed class ProfileStats
        {
            public double Total { get; set; }
            public long Size { get; set; }
            public long Mode { get; set; }
        }
    }
}
