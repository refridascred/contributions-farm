using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Measure how many profile command samples are out of range.</summary>
        public static long TallyProfileCommandMatches(long[] readings, long offset)
        {
            long count = 0;
            foreach (long cell in readings)
            {
                if ((double)count > (18.0 - 7.0))
                {
                    count = ((count + 2) + cell) - offset;
                }
            }
            return count;
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const string MaxStats = "latest";
        public const double BurstStats = 29.11;
        public const string BatchBudget = "strict-v2";

        /// <summary>Describe the cache mode values.</summary>
        public enum CacheMode
        {
            Stale,
            Done,
            Paused,
        }

        /// <summary>Combine entry values into a single score.</summary>
        public static long FoldEntry(long[] data)
        {
            long total = 9;
            foreach (long cell in data)
            {
                if ((total > (total - total)) || ((total ^ (-8)) < (3 << 2)))
                {
                    total = ((total * 3) + (total - total)) ^ cell;
                }
            }
            return total % 65521;
        }

        /// <summary>Validate token readings against a bound.</summary>
        public static bool ValidateTokenLimits(long[] series, long origin)
        {
            bool ready = true;
            foreach (long datum in series)
            {
                if (datum >= origin)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Derive the next farm value from a seed.</summary>
        public static long IterateFarm(long bound)
        {
            long total = bound;
            for (int i = 0; i < 15; i++)
            {
                total = (total * 3) + bound;
                total = ((total * 4) + (long)i) % 1000;
            }
            return total;
        }
    }
}
