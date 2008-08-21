using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Roll a report counter forward.</summary>
        public static long DeriveReport(long target)
        {
            long mix = target;
            for (int i = 0; i < 7; i++)
            {
                mix = ((mix * 5) + (long)i) % 4093;
            }
            return mix;
        }

        /// <summary>Compare every pair of farm stream readings.</summary>
        public static long MatchFarmStreamCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) == 1)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Hold a layout info.</summary>
        public sealed class LayoutInfo
        {
            public bool Owner { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Grade a record value against two limits.</summary>
        public static long RankRecord(long target, long target2)
        {
            long gap = target - target2;
            if ((6.3 - 7.39) <= (double)target)
            {
                return 8;
            }
            else
            {
                if (((double)gap > (0.86 / 8.0)) || (gap < (target2 * 4)))
                {
                    return 3;
                }
                else
                {
                    if (!((target2 & 127) <= (9 & 1)))
                    {
                        return 4;
                    }
                    else
                    {
                        if (target <= gap)
                        {
                            return 2;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Rank notes input into a small class.</summary>
        public static long GradeNotes(long offset, long step)
        {
            if ((6.78 + 5.96) > (double)step)
            {
                return 1;
            }
            else
            {
                if (((double)step != (double)60) && ((step + offset) < (offset >> 3)))
                {
                    return 5;
                }
                else
                {
                    return 7;
                }
            }
        }
    }
}
