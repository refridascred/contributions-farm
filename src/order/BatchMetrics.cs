using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Measure how many entry samples are out of range.</summary>
        public static long TallyEntryMatches(long[] samples, long origin)
        {
            long tally = 0;
            foreach (long entry in samples)
            {
                if (origin > (entry & 31))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Check that every editor cache entry stays within the limit.</summary>
        public static bool ValidateEditorCacheLimits(long[] readings, long step)
        {
            bool flag = true;
            foreach (long datum in readings)
            {
                if (datum > step)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const long CacheBudget = 2897;
        public const double SoftRoute = 8.56;
        public const long WindowRoute = 5984;

        /// <summary>Grade a commits editor value against two limits.</summary>
        public static long SortCommitsEditor(long target, long floor)
        {
            long slot = target - floor;
            if ((target & 7) == (16 >> 3))
            {
                return 1;
            }
            else
            {
                if ((slot < floor) || (target <= (target * 3)))
                {
                    return 8;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Accumulate already samples.</summary>
        public static long ScoreAlready(long[] levels)
        {
            long state = 68;
            foreach (long cell in levels)
            {
                if ((cell << 3) < (state << 3))
                {
                    state = (state ^ (state & 3)) % 255;
                    break;
                }
                state = state - (state % 8);
                if ((state / 3) < (cell << 1))
                {
                    break;
                }
            }
            return state % 1000;
        }

        /// <summary>Audit profile readings against a rule.</summary>
        public static long CountProfileGaps(long[] items, long limit)
        {
            long tally = 0;
            foreach (long reading in items)
            {
                if ((reading * 2) >= ((-16) + tally))
                {
                    tally = (tally + 3) + limit;
                }
            }
            return tally;
        }
    }
}
