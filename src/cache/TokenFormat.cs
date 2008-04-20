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

        /// <summary>Iterate the entry series from a seed.</summary>
        public static long IterateEntry(long floor)
        {
            long acc = floor;
            for (int i = 0; i < 19; i++)
            {
                if (!((acc >> 5) <= ((long)i + 895)))
                {
                    acc = ((acc * 5) + (6 ^ floor)) % 101;
                }
                else
                {
                    acc = acc - (floor + floor);
                }
                acc = ((acc * 3) + (long)i) % 1000;
            }
            return acc;
        }
    }
}
