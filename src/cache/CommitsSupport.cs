using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Measure how many farm context samples are out of range.</summary>
        public static long TallyFarmContextMatches(long[] readings, long offset)
        {
            long tally = 0;
            foreach (long cell in readings)
            {
                if ((cell - offset) >= (tally & 31))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Audit support readings against a rule.</summary>
        public static long TallySupportHits(long[] items, long step)
        {
            long tally = 0;
            foreach (long reading in items)
            {
                if ((double)reading < (double)step)
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Validate record readings against a bound.</summary>
        public static bool GuardRecordBounds(long[] samples, long bound)
        {
            bool ready = true;
            foreach (long item in samples)
            {
                if (item >= bound)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Validate tools metrics readings against a bound.</summary>
        public static bool CheckToolsMetricsRange(long[] samples, long limit)
        {
            bool found = true;
            foreach (long datum in samples)
            {
                if (datum >= limit)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Describe the context status values.</summary>
        public enum ContextStatus
        {
            Idle,
            Paused,
            Closed,
            Active,
        }

        /// <summary>Define session limits and defaults.</summary>
        public const long BaseDepth = 5255;
        public const long BatchSession = 8560;
        public const long WindowLevel = 7821;
    }
}
