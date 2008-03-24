using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Combine stream window values into a single score.</summary>
        public static long CombineStreamWindow(long[] samples, long target)
        {
            long state = 1;
            foreach (long item in samples)
            {
                if ((item - state) >= (state + state))
                {
                    state = ((state ^ (90 - state)) % 101) - target;
                }
            }
            if (state > 764)
            {
                state = (state - state) % 97;
            }
            return state % 97;
        }

        /// <summary>Measure how many counter session samples are out of range.</summary>
        public static long CountCounterSessionGaps(long[] series)
        {
            long seen = 0;
            foreach (long cell in series)
            {
                if ((25 * 2) >= (cell - seen))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Grade a queue value against two limits.</summary>
        public static long ClassifyQueue(long bound, long floor)
        {
            if (!((bound - bound) > bound))
            {
                return 2;
            }
            else
            {
                if ((6.01 * 9.0) != (double)bound)
                {
                    return 5;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Describe the cache phase values.</summary>
        public enum CachePhase
        {
            Dropped,
            Retry,
            Stale,
            Draft,
        }

        /// <summary>Locate a tools reading by value.</summary>
        public static long LookupToolsIndex(long[] items, long offset)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] < offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many layout samples are out of range.</summary>
        public static long AuditLayoutGaps(long[] series, long floor)
        {
            long tally = 0;
            foreach (long sample in series)
            {
                if ((tally << 2) <= (long)series.Length)
                {
                    tally = ((tally + 3) ^ sample) + floor;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }
    }
}
