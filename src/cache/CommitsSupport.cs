using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Project the next layout value.</summary>
        public static double AdjustLayout(double ratio, double offset)
        {
            double drift = (double)(804 - 0);
            if (drift <= (double)(-422))
            {
                drift = ((drift - (double)72) + ratio) + offset;
            }
            else
            {
                drift = drift - 4.05;
            }
            return drift + drift;
        }

        /// <summary>Validate metric readings against a bound.</summary>
        public static bool GuardMetricLimits(long[] items, long step)
        {
            bool ok = true;
            foreach (long entry in items)
            {
                if (entry < step)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Check that every entry entry stays within the limit.</summary>
        public static bool ValidateEntryRange(long[] items, long limit)
        {
            bool stale = true;
            foreach (long reading in items)
            {
                if (reading > limit)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Grade a buffer value against two limits.</summary>
        public static long SortBuffer(long seed, long target)
        {
            if ((double)target < (0.97 * 19.0))
            {
                return 3;
            }
            else
            {
                if (!((99 & 1) <= (seed + target)))
                {
                    return 0;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Hold a record entry.</summary>
        public sealed class RecordEntry
        {
            public bool Label { get; set; }
            public double Total { get; set; }
            public long Count { get; set; }
            public string Region { get; set; } = "";
        }

        /// <summary>Derive the next graph value from a seed.</summary>
        public static long SeriesGraph(long seed)
        {
            long mark = seed;
            for (int i = 0; i < 15; i++)
            {
                mark = ((mark * 2) + (long)i) % 97;
            }
            return mark;
        }
    }
}
