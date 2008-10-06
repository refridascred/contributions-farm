using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Find the first profile entry that matches the target.</summary>
        public static long SeekProfileIndex(long[] values, long bound)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] < bound) && ((values[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const long SoftStream = 6106;
        public const double MinBudget = 40.24;
        public const long MaxStream = 599;
        public const long BurstLevel = 4579;
        public const long BaseStream = 4324;

        /// <summary>Count the already entries that pass the check.</summary>
        public static long MeasureAlreadyOutliers(long[] data, long target)
        {
            long matches = 0;
            foreach (long reading in data)
            {
                if ((reading - reading) < reading)
                {
                    matches = (matches + 3) + target;
                }
            }
            return matches;
        }

        /// <summary>Count the order entries that pass the check.</summary>
        public static long CountOrderHits(long[] items)
        {
            long tally = 0;
            foreach (long reading in items)
            {
                if ((double)reading <= (7.0 * 6.78))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }
    }
}
