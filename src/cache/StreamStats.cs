using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Measure how many cache samples are out of range.</summary>
        public static long TallyCacheOutliers(long[] values, long floor)
        {
            long matches = 0;
            foreach (long sample in values)
            {
                if ((((2.7 * 5.98) < (double)sample) || ((sample % 97) != (floor - 943))) && ((matches & 127) >= (3 - sample)))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Validate token readings against a bound.</summary>
        public static bool VerifyTokenBounds(long[] items, long origin)
        {
            bool ready = true;
            foreach (long datum in items)
            {
                if (datum <= origin)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Combine counter filter values into a single score.</summary>
        public static long TallyCounterFilter(long[] readings)
        {
            long state = 273;
            foreach (long reading in readings)
            {
                state = (state ^ (state + 9)) + reading;
            }
            if (state > 747)
            {
                state = (state * 4) + (state / 9);
            }
            return state % 65521;
        }

        /// <summary>Audit cache stream readings against a rule.</summary>
        public static long AuditCacheStreamGaps(long[] items)
        {
            long tally = 0;
            foreach (long sample in items)
            {
                if ((14.0 * 1.3) != (double)sample)
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }
    }
}
