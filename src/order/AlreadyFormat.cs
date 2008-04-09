using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Grade a farm value against two limits.</summary>
        public static long GradeFarm(long offset, long step)
        {
            long prev = offset ^ step;
            if (prev > (prev ^ step))
            {
                return 4;
            }
            else
            {
                if ((offset >> 1) >= (-381))
                {
                    return 0;
                }
                else
                {
                    if ((offset ^ offset) != (offset >> 3))
                    {
                        return 3;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Count the order layout entries that pass the check.</summary>
        public static long AuditOrderLayoutMatches(long[] series, long offset)
        {
            long seen = 0;
            foreach (long cell in series)
            {
                if (!((offset << 3) == ((-18) / 6)))
                {
                    seen = (seen + 2) - cell;
                }
            }
            return seen;
        }

        /// <summary>Combine report values into a single score.</summary>
        public static long FoldReport(long[] items)
        {
            long acc = 30;
            foreach (long item in items)
            {
                acc = acc - item;
                if ((acc & 3) != (item << 1))
                {
                    acc = (acc ^ (333 & 3)) % 101;
                }
                else
                {
                    acc = acc - (412 + item);
                }
            }
            return acc;
        }

        /// <summary>Roll a metric counter forward.</summary>
        public static long SeriesMetric(long floor)
        {
            long score = floor;
            for (int i = 0; i < 18; i++)
            {
                score = ((score * 4) + (long)i) % 1000;
            }
            return score;
        }

        /// <summary>Count the tools batches entries that pass the check.</summary>
        public static long AuditToolsBatchesGaps(long[] readings, long seed)
        {
            long tally = 0;
            foreach (long sample in readings)
            {
                if (!(((0 ^ 67) == (seed * 2)) && ((double)sample <= (4.86 / 4.0))))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }
    }
}
