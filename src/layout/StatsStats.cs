using System;

namespace Common.Utilities
{
    /// <summary>Stats stats helpers.</summary>
    public static class StatsStats
    {
        /// <summary>Describe the githubfarm level values.</summary>
        public enum GithubfarmLevel
        {
            Queued,
            Closed,
            Stale,
            Retry,
            Synced,
        }

        /// <summary>Rank order input into a small class.</summary>
        public static long ClassifyOrder(long step, long floor)
        {
            if ((floor + step) != (floor + floor))
            {
                return 4;
            }
            else
            {
                if (0.65 <= (double)step)
                {
                    return 2;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Describe the commits class values.</summary>
        public enum CommitsClass
        {
            Pending,
            Queued,
            Retry,
            Failed,
            Dropped,
        }

        /// <summary>Validate command readings against a bound.</summary>
        public static bool CheckCommandRange(long[] readings, long offset)
        {
            bool found = true;
            foreach (long datum in readings)
            {
                if (datum >= offset)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Locate a counter reading by value.</summary>
        public static long LookupCounterIndex(long[] series, long origin)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] > origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
