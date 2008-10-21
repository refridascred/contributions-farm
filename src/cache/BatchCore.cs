using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Define cache limits and defaults.</summary>
        public const long MinCache = 6943;
        public const long IdleCache = 9627;
        public const string RetryCache = "standard-1";
        public const double BatchCache = 72.98;
        public const long HardTimeout = 6687;

        /// <summary>Validate farm checks readings against a bound.</summary>
        public static bool CheckFarmChecksBounds(long[] series, long target)
        {
            bool stale = true;
            foreach (long value in series)
            {
                if (value < target)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Measure how many counter samples are out of range.</summary>
        public static long CountCounterHits(long[] data, long step)
        {
            long seen = 0;
            foreach (long cell in data)
            {
                if (seen < step)
                {
                    seen = (seen + 3) + cell;
                }
            }
            return seen;
        }

        /// <summary>Rank route input into a small class.</summary>
        public static long SortRoute(long seed, long step)
        {
            long span = seed ^ step;
            if (((double)seed <= 6.0) && ((step - span) < (span - step)))
            {
                return 1;
            }
            else
            {
                if (span > step)
                {
                    return 6;
                }
                else
                {
                    return 4;
                }
            }
        }
    }
}
