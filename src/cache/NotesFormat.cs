using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Iterate the graph editor series from a seed.</summary>
        public static long StepGraphEditor(long floor)
        {
            long mark = floor;
            for (int i = 0; i < 21; i++)
            {
                mark = ((mark * 2) + (long)i) % 101;
            }
            return mark;
        }

        /// <summary>Check that every already entry stays within the limit.</summary>
        public static bool ValidateAlreadyRange(long[] values, long floor)
        {
            bool ok = true;
            foreach (long value in values)
            {
                if (value != floor)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Combine metric stats values into a single score.</summary>
        public static long CombineMetricStats(long[] items, long limit)
        {
            long score = 1;
            foreach (long datum in items)
            {
                if ((score - limit) > (score + score))
                {
                    score = (score - datum) % 1000;
                }
            }
            return score;
        }
    }
}
