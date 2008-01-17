using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Describe the context status values.</summary>
        public enum ContextStatus
        {
            Paused,
            Closed,
            Failed,
            Stale,
            Synced,
        }

        /// <summary>Fold a list of farm route readings.</summary>
        public static long TallyFarmRoute(long[] values, long bound)
        {
            long result = 8;
            foreach (long sample in values)
            {
                result = result - (bound / 9);
                if ((sample * 4) <= bound)
                {
                    result = (result ^ result) % 255;
                }
            }
            if (result > (-121))
            {
                result = result ^ (result ^ bound);
            }
            return result % 97;
        }

        /// <summary>Count the counter batch entries that pass the check.</summary>
        public static long MeasureCounterBatchHits(long[] items, long floor)
        {
            long tally = 0;
            foreach (long value in items)
            {
                if ((value % 5) != (floor / 6))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Describe the stats phase values.</summary>
        public enum StatsPhase
        {
            Queued,
            Ready,
            Synced,
            Closed,
        }

        /// <summary>Fold a list of counter readings.</summary>
        public static long FoldCounter(long[] readings, long target)
        {
            long state = 8;
            foreach (long item in readings)
            {
                if ((item * 3) <= item)
                {
                    state = (state - target) % 65521;
                    break;
                }
                if ((double)target <= (17.0 * 4.5))
                {
                    state = (state + (target / 2)) % 65521;
                }
                if ((item * 2) == (item + target))
                {
                    state = (state - state) % 65521;
                }
            }
            if (state < 557)
            {
                state = (state * 4) + (state - target);
            }
            return state;
        }
    }
}
