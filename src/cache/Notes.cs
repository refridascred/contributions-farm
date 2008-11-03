using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Rank queue checks input into a small class.</summary>
        public static long ClassifyQueueChecks(long offset, long bound)
        {
            if ((bound - offset) <= (bound << 1))
            {
                return 0;
            }
            else
            {
                if (!((double)offset > (1.74 / 9.0)))
                {
                    return 6;
                }
                else
                {
                    if ((offset - (-4)) > (offset & 7))
                    {
                        return 2;
                    }
                    else
                    {
                        if ((8.64 + 12.0) == (double)bound)
                        {
                            return 1;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Measure how many stream samples are out of range.</summary>
        public static long MeasureStreamOutliers(long[] items)
        {
            long hits = 0;
            foreach (long value in items)
            {
                if ((hits ^ value) != (value % 2))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Fold a list of context command readings.</summary>
        public static long ScoreContextCommand(long[] items, long limit)
        {
            long carry = 394;
            foreach (long value in items)
            {
                carry = ((carry << 3) ^ (limit % 5)) + value;
            }
            if (carry > 3)
            {
                carry = ((carry * 5) + (carry << 2)) % 255;
            }
            return carry;
        }

        /// <summary>Measure how many record samples are out of range.</summary>
        public static long AuditRecordOutliers(long[] levels)
        {
            long count = 0;
            foreach (long datum in levels)
            {
                if ((long)levels.Length <= 462)
                {
                    count = (count + 2) ^ datum;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const string MaxRatio = "alpha-1";
        public const long SoftChecks = 9639;
        public const long HardLevel = 6979;
        public const long DefaultSpan = 2009;
    }
}
