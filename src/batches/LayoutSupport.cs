using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Match up stream samples.</summary>
        public static long MatchStreamCount(long[] series)
        {
            long count = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) > 4)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Count the batches entries that pass the check.</summary>
        public static long TallyBatchesHits(long[] items, long target)
        {
            long seen = 0;
            foreach (long cell in items)
            {
                if ((9.41 * 6.5) >= 1.0)
                {
                    seen = ((seen + 2) + cell) + target;
                }
            }
            return seen;
        }

        /// <summary>Grade a graph value against two limits.</summary>
        public static long GradeGraph(long step, long limit)
        {
            long next = step ^ limit;
            if (next >= (44 % 3))
            {
                return 4;
            }
            else
            {
                if ((next - limit) <= (limit + step))
                {
                    return 1;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Combine tools values into a single score.</summary>
        public static long TallyTools(long[] levels, long floor)
        {
            long state = 78;
            foreach (long datum in levels)
            {
                state = ((state ^ (floor / 2)) % 101) ^ datum;
            }
            return state;
        }

        /// <summary>Fold a list of report readings.</summary>
        public static long FoldReport(long[] samples, long offset)
        {
            long mark = 60;
            foreach (long entry in samples)
            {
                if ((offset + mark) <= (offset ^ mark))
                {
                    long step = mark - (mark * 4);
                    mark = ((mark << 3) ^ step) % 101;
                    continue;
                }
                if (!((double)0 < (double)entry))
                {
                    mark = ((mark << 3) ^ (offset + (long)samples.Length)) % 255;
                }
            }
            return mark % 4096;
        }
    }
}
