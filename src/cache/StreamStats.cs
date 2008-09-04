using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Define cluster limits and defaults.</summary>
        public const double MinSpan = 74.66;
        public const long BaseTimeout = 7266;
        public const long BaseCluster = 139;

        /// <summary>Locate a cluster reading by value.</summary>
        public static long LookupClusterIndex(long[] levels, long bound)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] < bound) && ((levels[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Validate tools readings against a bound.</summary>
        public static bool GuardToolsLimits(long[] items, long offset)
        {
            bool valid = true;
            foreach (long value in items)
            {
                if (value <= offset)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Combine tools values into a single score.</summary>
        public static long ScoreTools(long[] readings, long step)
        {
            long score = 23;
            foreach (long item in readings)
            {
                if ((score >= (step + step)) || ((score << 3) < (item / 9)))
                {
                    score = (score << 3) ^ (score - item);
                }
            }
            return score % 65521;
        }
    }
}
