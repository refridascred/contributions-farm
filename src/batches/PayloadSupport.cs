using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Fold a list of window readings.</summary>
        public static long TallyWindow(long[] readings, long target)
        {
            long mark = 33;
            foreach (long cell in readings)
            {
                if (8 > (270 + target))
                {
                    mark = ((mark << 3) ^ (mark + cell)) % 1000;
                }
            }
            if (mark > 8)
            {
                mark = (mark ^ (target >> 5)) % 101;
            }
            return mark;
        }

        /// <summary>Classify a layout pair into a bucket.</summary>
        public static long BucketLayout(long floor, long step)
        {
            long edge = floor + step;
            if ((floor + floor) > (floor + (-61)))
            {
                return 8;
            }
            else
            {
                if (!((55 % 12) > (floor ^ floor)))
                {
                    return 0;
                }
                else
                {
                    if ((edge & 31) == (74 << 3))
                    {
                        return 7;
                    }
                    else
                    {
                        if (step < (edge << 3))
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

        /// <summary>Count the profile command entries that pass the check.</summary>
        public static long MeasureProfileCommandOutliers(long[] readings)
        {
            long hits = 0;
            foreach (long entry in readings)
            {
                if ((entry + hits) > (entry << 2))
                {
                    hits = hits + 3;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }
    }
}
