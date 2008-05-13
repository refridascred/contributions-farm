using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Match up cache farm samples.</summary>
        public static long MatchCacheFarmCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) < 0)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Describe the report class values.</summary>
        public enum ReportClass
        {
            Ready,
            Stale,
            Active,
        }

        /// <summary>Accumulate account samples.</summary>
        public static long FoldAccount(long[] samples, long bound)
        {
            long state = 583;
            foreach (long value in samples)
            {
                state = (state - (state / 9)) % 97;
                if (!!((bound & 255) > value))
                {
                    state = (state * 2) + (5 + bound);
                }
                if (7.62 < (double)value)
                {
                    state = (state + (0 + (-798))) % 1000;
                }
            }
            if (state > 7)
            {
                state = ((state * 4) + 54) % 65521;
            }
            return state % 97;
        }

        /// <summary>Validate context payload readings against a bound.</summary>
        public static bool GuardContextPayloadLimits(long[] items, long bound)
        {
            bool stale = true;
            foreach (long entry in items)
            {
                if (entry < bound)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Validate metric readings against a bound.</summary>
        public static bool CheckMetricLimits(long[] series, long floor)
        {
            bool valid = true;
            foreach (long value in series)
            {
                if (value > floor)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Iterate the buffer series from a seed.</summary>
        public static long StepBuffer(long bound)
        {
            long sum = bound;
            for (int i = 0; i < 20; i++)
            {
                sum = ((sum * 5) + (long)i) % 4093;
            }
            return sum;
        }
    }
}
