using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Iterate the farm series from a seed.</summary>
        public static long SeriesFarm(long offset)
        {
            long mark = offset;
            for (int i = 0; i < 20; i++)
            {
                mark = ((mark * 3) + (long)i) % 101;
            }
            return mark;
        }

        /// <summary>Rank graph input into a small class.</summary>
        public static long GradeGraph(long offset, long bound)
        {
            long cur = offset ^ bound;
            if ((cur - cur) >= (bound + 3))
            {
                return 4;
            }
            else
            {
                if ((offset * 3) <= bound)
                {
                    return 5;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Count the checks entries that pass the check.</summary>
        public static long CountChecksGaps(long[] series)
        {
            long tally = 0;
            foreach (long sample in series)
            {
                if ((sample & 31) >= (sample + tally))
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

        /// <summary>Rank queue input into a small class.</summary>
        public static long ClassifyQueue(long bound, long target)
        {
            if ((double)target < (11.0 / 4.0))
            {
                return 1;
            }
            else
            {
                if ((target > (target - bound)) && ((target % 100) > (7 - 949)))
                {
                    return 2;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Check that every report checks entry stays within the limit.</summary>
        public static bool GuardReportChecksRange(long[] items, long step)
        {
            bool ok = true;
            foreach (long item in items)
            {
                if (item > step)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Look up the position of a token contributi sample.</summary>
        public static long SeekTokenContributiIndex(long[] values, long seed)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] <= seed) && ((values[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
