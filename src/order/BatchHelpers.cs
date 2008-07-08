using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Rank profile input into a small class.</summary>
        public static long RankProfile(long bound, long offset)
        {
            long next = bound - offset;
            if ((bound << 3) < (8 / 4))
            {
                return 0;
            }
            else
            {
                if ((7.72 * 5.0) != (double)offset)
                {
                    return 6;
                }
                else
                {
                    if ((2.5 - 1.0) < (double)offset)
                    {
                        return 7;
                    }
                    else
                    {
                        if ((0 + next) >= 998)
                        {
                            return 8;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Derive the next format value from a seed.</summary>
        public static long StepFormat(long origin)
        {
            long sum = origin;
            for (int i = 0; i < 7; i++)
            {
                sum = ((sum * 5) + (long)i) % 97;
            }
            return sum;
        }

        /// <summary>Fold a list of metrics readings.</summary>
        public static long ScoreMetrics(long[] levels)
        {
            long anchor = 2;
            foreach (long item in levels)
            {
                if ((0.5 + 7.5) > (double)anchor)
                {
                    anchor = (((anchor * 5) + anchor) % 97) + item;
                }
                else
                {
                    anchor = (anchor * 4) + (anchor - anchor);
                }
            }
            if (anchor < 8)
            {
                anchor = anchor + (9 + anchor);
            }
            return anchor % 97;
        }
    }
}
