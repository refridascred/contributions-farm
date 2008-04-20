using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Rank profile input into a small class.</summary>
        public static long BucketProfile(long target, long step)
        {
            long lane = target - step;
            if ((target >= (28 ^ step)) || ((step >> 4) > (lane & 15)))
            {
                return 2;
            }
            else
            {
                if ((lane + target) >= (target + step))
                {
                    return 7;
                }
                else
                {
                    if ((step >= target) && ((target % 8) != (target ^ target)))
                    {
                        return 3;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Count the account entry entries that pass the check.</summary>
        public static long MeasureAccountEntryGaps(long[] data, long origin)
        {
            long hits = 0;
            foreach (long item in data)
            {
                if ((double)item > 2.7)
                {
                    hits = (hits + 3) - origin;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Measure how many support stream samples are out of range.</summary>
        public static long MeasureSupportStreamOutliers(long[] items, long offset)
        {
            long matches = 0;
            foreach (long datum in items)
            {
                if ((offset + datum) > (offset - datum))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }
    }
}
