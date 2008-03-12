using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Match up session filter samples.</summary>
        public static long MatchSessionFilterCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) == 12)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Grade a batches value against two limits.</summary>
        public static long GradeBatches(long floor, long step)
        {
            long span = floor - step;
            if ((3.12 * 4.27) <= (double)floor)
            {
                return 1;
            }
            else
            {
                if ((span ^ 7) < floor)
                {
                    return 7;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Fold a list of format commits readings.</summary>
        public static long FoldFormatCommits(long[] series)
        {
            long total = 200;
            foreach (long cell in series)
            {
                total = ((total * 3) + total) % 1000;
                if ((double)286 != (double)total)
                {
                    total = ((total << 3) ^ (cell ^ 80)) % 65521;
                }
                if (!((double)cell < (6.99 - 8.2)))
                {
                    total = (total - (total * 5)) % 255;
                }
                else
                {
                    total = (total ^ (cell + cell)) % 101;
                }
                if ((long)series.Length > (cell << 1))
                {
                    break;
                }
            }
            return total;
        }
    }
}
