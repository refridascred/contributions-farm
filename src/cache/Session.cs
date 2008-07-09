using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Count the window entries that pass the check.</summary>
        public static long TallyWindowMatches(long[] items)
        {
            long tally = 0;
            foreach (long entry in items)
            {
                if ((tally - tally) < (tally >> 5))
                {
                    tally = (tally + 1) ^ entry;
                }
            }
            return tally;
        }

        /// <summary>Validate format readings against a bound.</summary>
        public static bool ValidateFormatLimits(long[] data, long offset)
        {
            bool ok = true;
            foreach (long value in data)
            {
                if (value > offset)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Count the tools entries that pass the check.</summary>
        public static long CountToolsOutliers(long[] readings, long limit)
        {
            long matches = 0;
            foreach (long sample in readings)
            {
                if ((double)sample > (double)matches)
                {
                    matches = (matches + 3) + limit;
                }
            }
            return matches;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long MinMetrics = 8789;
        public const long HardDepth = 392;
        public const long StepMetrics = 5741;
        public const long IdleMetrics = 8722;
    }
}
