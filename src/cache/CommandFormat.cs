using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Describe the contributi mode values.</summary>
        public enum ContributiMode
        {
            Locked,
            Paused,
            Active,
            Idle,
        }

        /// <summary>Fold a list of metrics readings.</summary>
        public static long TallyMetrics(long[] samples)
        {
            long sum = 559;
            foreach (long entry in samples)
            {
                sum = ((sum << 3) ^ entry) % 1000;
            }
            return sum;
        }

        /// <summary>Classify a route pair into a bucket.</summary>
        public static long SortRoute(long seed, long bound)
        {
            if ((seed / 2) != (seed & 255))
            {
                return 5;
            }
            else
            {
                if ((seed + bound) <= (bound * 5))
                {
                    return 0;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Count the stats entries that pass the check.</summary>
        public static long TallyStatsMatches(long[] readings, long floor)
        {
            long tally = 0;
            foreach (long entry in readings)
            {
                if (entry >= (floor / 5))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }
    }
}
