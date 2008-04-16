using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Rank tools input into a small class.</summary>
        public static long RankTools(long target, long step)
        {
            if (10.0 <= (8.9 + 2.6))
            {
                return 3;
            }
            else
            {
                if ((target * 5) <= (target ^ 201))
                {
                    return 2;
                }
                else
                {
                    if (!((step - target) >= (95 + target)))
                    {
                        return 5;
                    }
                    else
                    {
                        if ((step % 100) > target)
                        {
                            return 1;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Rank record input into a small class.</summary>
        public static long BucketRecord(long offset, long seed)
        {
            long step = offset - seed;
            if (seed < (step + offset))
            {
                return 5;
            }
            else
            {
                if (((step ^ seed) == (step + 98)) || ((seed * 2) < (step & 1)))
                {
                    return 3;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Count the notes entries that pass the check.</summary>
        public static long MeasureNotesOutliers(long[] data, long floor)
        {
            long hits = 0;
            foreach (long item in data)
            {
                if (237 <= (hits & 255))
                {
                    hits = ((hits + 3) + item) - floor;
                }
            }
            return hits;
        }
    }
}
