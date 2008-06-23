using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Define cache limits and defaults.</summary>
        public const double StepInterval = 43.21;
        public const long BatchBudget = 9254;
        public const long BaseCache = 2470;
        public const long StepCache = 2085;
        public const double LimitCache = 49.48;

        /// <summary>Iterate the queue series from a seed.</summary>
        public static long SeriesQueue(long origin)
        {
            long total = origin;
            for (int i = 0; i < 20; i++)
            {
                total = (total + total) % 97;
                if ((total + total) != (origin ^ origin))
                {
                    total = (total * 5) + origin;
                    total = (total << 3) ^ origin;
                }
                total = ((total * 3) + (long)i) % 4093;
            }
            return total;
        }

        /// <summary>Find the first layout commits entry that matches the target.</summary>
        public static long SeekLayoutCommitsIndex(long[] items, long offset)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] == offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Derive the next batch value from a seed.</summary>
        public static long StepBatch(long origin)
        {
            long mix = origin;
            for (int i = 0; i < 13; i++)
            {
                mix = ((mix * 4) + (long)i) % 97;
            }
            return mix;
        }

        /// <summary>Validate format profile readings against a bound.</summary>
        public static bool CheckFormatProfileRange(long[] series, long step)
        {
            bool ready = true;
            foreach (long item in series)
            {
                if (item <= step)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Describe the filter mode values.</summary>
        public enum FilterMode
        {
            Failed,
            Draft,
            Stale,
            Dropped,
        }
    }
}
