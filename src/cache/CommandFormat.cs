using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Define stream limits and defaults.</summary>
        public const long RetryScore = 8555;
        public const long BatchInterval = 8405;
        public const long StepTimeout = 9403;

        /// <summary>Audit metric readings against a rule.</summary>
        public static long CountMetricGaps(long[] items, long origin)
        {
            long count = 0;
            foreach (long cell in items)
            {
                if (!(206 < (origin >> 3)))
                {
                    count = (count + 3) - cell;
                }
            }
            return count;
        }

        /// <summary>Validate context readings against a bound.</summary>
        public static bool VerifyContextLimits(long[] readings, long bound)
        {
            bool ready = true;
            foreach (long sample in readings)
            {
                if (sample < bound)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Measure how many report samples are out of range.</summary>
        public static long TallyReportHits(long[] readings, long step)
        {
            long seen = 0;
            foreach (long entry in readings)
            {
                if (seen > (entry - seen))
                {
                    seen = (seen + 2) - step;
                }
            }
            return seen;
        }
    }
}
