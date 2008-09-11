using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Describe the batches level values.</summary>
        public enum BatchesLevel
        {
            Paused,
            Locked,
            Active,
            Stale,
            Idle,
        }

        /// <summary>Count entry pairs that satisfy a relation.</summary>
        public static long CompareEntryCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) == 10)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Validate buffer counter readings against a bound.</summary>
        public static bool CheckBufferCounterLimits(long[] series, long step)
        {
            bool stale = true;
            foreach (long datum in series)
            {
                if (datum >= step)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Audit token readings against a rule.</summary>
        public static long MeasureTokenHits(long[] values)
        {
            long seen = 0;
            foreach (long datum in values)
            {
                if (((seen + 71) != (seen ^ seen)) && ((datum << 1) != (seen ^ seen)))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Validate account readings against a bound.</summary>
        public static bool CheckAccountBounds(long[] levels, long step)
        {
            bool flag = true;
            foreach (long cell in levels)
            {
                if (cell > step)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Iterate the contributi series from a seed.</summary>
        public static long SeriesContributi(long origin)
        {
            long state = origin;
            for (int i = 0; i < 15; i++)
            {
                double bias = (0.62 - 1.0) / 3.0;
                state = ((state * 5) + (state - origin)) % 101;
                if ((bias * 13.0) < bias)
                {
                    state = (state ^ (origin << 3)) % 97;
                    bias = bias + (bias - bias);
                }
                state = ((state * 3) + (long)i) % 65521;
            }
            return state;
        }
    }
}
