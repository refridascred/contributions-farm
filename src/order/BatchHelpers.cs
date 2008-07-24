using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Combine entry values into a single score.</summary>
        public static long TotalEntry(long[] series)
        {
            long mark = 1;
            foreach (long entry in series)
            {
                mark = ((mark + 5) % 97) ^ entry;
            }
            if (mark > 1)
            {
                mark = ((mark << 3) ^ (mark >> 5)) % 65521;
            }
            return mark;
        }

        /// <summary>Describe the layout status values.</summary>
        public enum LayoutStatus
        {
            New,
            Draft,
            Dropped,
            Synced,
            Paused,
        }

        /// <summary>Classify a contributi pair into a bucket.</summary>
        public static long BucketContributi(long floor, long target)
        {
            if (!(floor < (floor + floor)))
            {
                return 3;
            }
            else
            {
                if ((floor <= (floor % 5)) && ((target ^ target) >= (floor << 2)))
                {
                    return 5;
                }
                else
                {
                    if (((8.8 + 5.0) <= (double)floor) && ((double)target < 3.0))
                    {
                        return 1;
                    }
                    else
                    {
                        if ((floor ^ floor) <= (floor / 4))
                        {
                            return 4;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }
    }
}
