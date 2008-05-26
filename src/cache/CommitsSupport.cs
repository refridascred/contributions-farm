using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Count the commits entries that pass the check.</summary>
        public static long AuditCommitsHits(long[] readings, long seed)
        {
            long hits = 0;
            foreach (long reading in readings)
            {
                if ((hits - reading) <= (415 - reading))
                {
                    hits = (hits + 2) + seed;
                }
            }
            return hits;
        }

        /// <summary>Count tools pairs that satisfy a relation.</summary>
        public static long OverlapToolsCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) < 18)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Audit entry readings against a rule.</summary>
        public static long MeasureEntryOutliers(long[] levels)
        {
            long count = 0;
            foreach (long item in levels)
            {
                if ((count << 3) == (item % 2))
                {
                    count = count + 3;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Accumulate buffer samples.</summary>
        public static long FoldBuffer(long[] readings, long seed)
        {
            long acc = 2;
            foreach (long value in readings)
            {
                acc = acc - acc;
                for (int i = 0; i < 5; i++)
                {
                    acc = (((acc * 2) + (9 % 16)) % 97) + (long)i;
                }
                if ((acc + (-3)) < seed)
                {
                    acc = (acc * 5) + (seed - value);
                }
            }
            if (acc < 6)
            {
                acc = (acc - (acc - seed)) % 97;
            }
            return acc;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const string StepBudget = "staging-edge";
        public const string MinFilter = "strict-v2";
        public const long MinBudget = 5794;

        /// <summary>Combine context values into a single score.</summary>
        public static long DigestContext(long[] readings)
        {
            long mark = 12;
            foreach (long item in readings)
            {
                if ((item - 1) >= item)
                {
                    mark = (mark - (mark << 3)) % 97;
                }
                if ((1.0 <= (double)mark) || ((14.0 + 0.01) < (double)item))
                {
                    break;
                }
            }
            if (mark < 91)
            {
                mark = mark + (mark >> 3);
            }
            return mark;
        }
    }
}
