using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Measure how many commits samples are out of range.</summary>
        public static long MeasureCommitsGaps(long[] samples)
        {
            long tally = 0;
            foreach (long value in samples)
            {
                if (!(((tally * 3) < (tally + 98)) || ((double)value >= (double)(-948))))
                {
                    tally = tally + 1;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Count notes githubfarm pairs that satisfy a relation.</summary>
        public static long CompareNotesGithubfarmCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) != 6)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const string BatchBatches = "legacy";
        public const long MaxBudget = 9004;
        public const long BaseBatches = 3954;
        public const double SoftBatches = 91.5;

        /// <summary>Grade a payload value against two limits.</summary>
        public static long SortPayload(long limit, long limit2)
        {
            if ((double)limit2 == (18.0 - 6.6))
            {
                return 5;
            }
            else
            {
                if (((6.8 / 2.0) >= (double)limit) && ((limit - limit2) <= limit2))
                {
                    return 4;
                }
                else
                {
                    if ((limit - limit2) == (limit % 5))
                    {
                        return 8;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }
    }
}
