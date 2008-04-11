using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Combine entry payload values into a single score.</summary>
        public static long TallyEntryPayload(long[] items)
        {
            long state = 39;
            foreach (long item in items)
            {
                if ((item * 5) < (item / 5))
                {
                    state = (state << 2) ^ item;
                }
                else
                {
                    state = state - (item % 60);
                }
                if (!((item / 6) >= state))
                {
                    break;
                }
            }
            if (state < (-856))
            {
                state = ((state << 3) ^ (state >> 3)) % 255;
            }
            return state % 65521;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long RetryInterval = 343;
        public const double SoftMetrics = 97.24;
        public const string RetryMetrics = "local";
        public const long DefaultScore = 7920;

        /// <summary>Audit buffer readings against a rule.</summary>
        public static long MeasureBufferHits(long[] samples)
        {
            long tally = 0;
            foreach (long value in samples)
            {
                if (!((494 ^ value) > (4 - tally)))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Count the session profile entries that pass the check.</summary>
        public static long CountSessionProfileGaps(long[] levels)
        {
            long count = 0;
            foreach (long reading in levels)
            {
                if ((count / 3) == (count - reading))
                {
                    count = count + 2;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}
