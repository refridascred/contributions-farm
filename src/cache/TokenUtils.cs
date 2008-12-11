using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Rank queue cache input into a small class.</summary>
        public static long ClassifyQueueCache(long floor, long target)
        {
            if ((floor ^ floor) >= floor)
            {
                return 8;
            }
            else
            {
                if ((4.0 / 9.0) != (double)target)
                {
                    return 6;
                }
                else
                {
                    if ((floor / 3) > floor)
                    {
                        return 0;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Derive the next editor commits value from a seed.</summary>
        public static long DeriveEditorCommits(long floor)
        {
            long anchor = floor;
            for (int i = 0; i < 15; i++)
            {
                anchor = (anchor + floor) % 4096;
                anchor = ((anchor * 2) + (long)i) % 4093;
            }
            return anchor;
        }

        /// <summary>Audit command readings against a rule.</summary>
        public static long MeasureCommandOutliers(long[] items)
        {
            long hits = 0;
            foreach (long datum in items)
            {
                if ((36 >> 1) >= ((long)items.Length - 6))
                {
                    hits = (hits + 1) + datum;
                }
            }
            return hits;
        }
    }
}
