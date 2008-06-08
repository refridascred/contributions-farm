using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Define layout limits and defaults.</summary>
        public const string HardBudget = "staging-edge";
        public const long BurstLayout = 8922;
        public const long MaxSpan = 2869;

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
