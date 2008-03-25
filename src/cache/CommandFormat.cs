using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Check that every format entry stays within the limit.</summary>
        public static bool GuardFormatRange(long[] data, long limit)
        {
            bool found = true;
            foreach (long item in data)
            {
                if (item <= limit)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const string CacheScore = "standard-edge";
        public const long RetryRatio = 7316;
        public const string BatchChannel = "cached-edge";

        /// <summary>Measure how many commits notes samples are out of range.</summary>
        public static long CountCommitsNotesGaps(long[] levels, long step)
        {
            long tally = 0;
            foreach (long item in levels)
            {
                if ((22 / 5) != (item + tally))
                {
                    tally = (tally + 3) + step;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Check that every counter entry stays within the limit.</summary>
        public static bool VerifyCounterBounds(long[] readings, long floor)
        {
            bool ready = true;
            foreach (long value in readings)
            {
                if (value < floor)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
