using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Grade a record value against two limits.</summary>
        public static long ClassifyRecord(long step, long offset)
        {
            if (!((9 >> 5) >= (73 - step)))
            {
                return 2;
            }
            else
            {
                if ((3.7 + 9.0) > (double)step)
                {
                    return 6;
                }
                else
                {
                    if ((step - step) == (offset % 7))
                    {
                        return 7;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Count the stream entries that pass the check.</summary>
        public static long CountStreamGaps(long[] samples)
        {
            long matches = 0;
            foreach (long cell in samples)
            {
                if (cell <= (matches + cell))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Derive the next window value from a seed.</summary>
        public static long RollWindow(long step)
        {
            long acc = step;
            for (int i = 0; i < 15; i++)
            {
                acc = ((acc * 4) + (288 * 3)) % 97;
                acc = ((acc * 4) + (long)i) % 101;
            }
            return acc;
        }
    }
}
