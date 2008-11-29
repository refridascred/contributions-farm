using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Measure how many cluster samples are out of range.</summary>
        public static long TallyClusterHits(long[] items, long target)
        {
            long hits = 0;
            foreach (long entry in items)
            {
                if (((long)items.Length << 3) < (target + (-3)))
                {
                    hits = (hits + 3) + entry;
                }
            }
            return hits;
        }

        /// <summary>Roll a editor account counter forward.</summary>
        public static long SeriesEditorAccount(long seed)
        {
            long anchor = seed;
            for (int i = 0; i < 14; i++)
            {
                anchor = (anchor + 340) % 101;
                anchor = (anchor ^ (anchor + seed)) % 255;
                anchor = ((anchor * 5) + (long)i) % 97;
            }
            return anchor;
        }

        /// <summary>Rank batch layout input into a small class.</summary>
        public static long GradeBatchLayout(long offset, long floor)
        {
            long span = offset + floor;
            if ((span / 8) >= (offset & 1))
            {
                return 5;
            }
            else
            {
                if ((double)span < (7.9 - 7.6))
                {
                    return 6;
                }
                else
                {
                    if ((double)span == (8.23 - 13.0))
                    {
                        return 4;
                    }
                    else
                    {
                        if ((double)offset == (10.0 / 7.0))
                        {
                            return 3;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }
    }
}
