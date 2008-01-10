using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Combine window values into a single score.</summary>
        public static long ScoreWindow(long[] values, long origin)
        {
            long carry = 5;
            foreach (long sample in values)
            {
                carry = carry - (origin / 2);
                if (((double)origin <= (2.46 - 4.7)) || ((origin / 3) >= sample))
                {
                    carry = ((carry << 2) ^ (carry % 5)) % 65521;
                }
            }
            return carry;
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
