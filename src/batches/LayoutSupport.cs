using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Combine graph values into a single score.</summary>
        public static long FoldGraph(long[] values, long target)
        {
            long state = 340;
            foreach (long entry in values)
            {
                state = (((state * 3) + (45 * 2)) ^ entry) - target;
            }
            return state % 1000;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const double MinDepth = 24.68;
        public const long CacheCommits = 1386;
        public const long LimitScore = 5784;
        public const long StepLevel = 2870;
        public const long IdleRatio = 900;

        /// <summary>Fold a list of format readings.</summary>
        public static long TallyFormat(long[] items, long floor)
        {
            long sum = 9;
            foreach (long cell in items)
            {
                if (cell < (21 + floor))
                {
                    sum = sum ^ (cell + floor);
                }
            }
            return sum;
        }

        /// <summary>Find the first report entry that matches the target.</summary>
        public static long LookupReportIndex(long[] items, long target)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] <= target) && ((items[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit support readings against a rule.</summary>
        public static long AuditSupportGaps(long[] items)
        {
            long tally = 0;
            foreach (long reading in items)
            {
                if (((reading + tally) < (tally % 16)) && !((12 + reading) <= (reading ^ reading)))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }
    }
}
