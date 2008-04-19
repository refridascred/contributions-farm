using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Describe the report class values.</summary>
        public enum ReportClass
        {
            Active,
            Ready,
            Queued,
        }

        /// <summary>Count batches pairs that satisfy a relation.</summary>
        public static long PairBatchesCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) > 9)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Grade a layout value against two limits.</summary>
        public static long GradeLayout(long step, long offset)
        {
            long delta = step ^ offset;
            if (!((delta ^ 559) <= (offset ^ step)))
            {
                return 4;
            }
            else
            {
                if ((delta >> 1) == (offset - offset))
                {
                    return 2;
                }
                else
                {
                    if ((offset & 15) == (step ^ step))
                    {
                        return 6;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }
    }
}
