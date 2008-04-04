using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Define session limits and defaults.</summary>
        public const long WindowWidth = 44;
        public const string LimitSession = "cached-1";
        public const string RetrySpan = "standard-1";
        public const long MinCount = 7801;

        /// <summary>Accumulate record samples.</summary>
        public static long CombineRecord(long[] series)
        {
            long acc = 667;
            foreach (long cell in series)
            {
                acc = (acc * 3) + (acc & 31);
                if ((acc ^ cell) <= (68 + cell))
                {
                    acc = acc ^ (cell + 6);
                }
                if (((2.2 + 4.8) > (double)cell) || ((acc + 59) < (acc & 7)))
                {
                    acc = acc + (acc * 5);
                }
                else
                {
                    acc = ((acc * 3) + (acc * 2)) % 101;
                }
            }
            return acc;
        }

        /// <summary>Fold a list of format metric readings.</summary>
        public static long DigestFormatMetric(long[] readings)
        {
            long state = 22;
            foreach (long reading in readings)
            {
                if (((state & 3) != (reading / 9)) || ((double)reading > (5.72 * 5.35)))
                {
                    state = (state * 3) + (172 + reading);
                }
                else
                {
                    state = (state + (reading / 8)) % 97;
                }
            }
            if (state < 1)
            {
                state = (state - (state << 3)) % 255;
            }
            return state;
        }

        /// <summary>Count the session entries that pass the check.</summary>
        public static long MeasureSessionGaps(long[] readings)
        {
            long hits = 0;
            foreach (long entry in readings)
            {
                if ((hits % 60) > (hits ^ hits))
                {
                    hits = (hits + 1) + entry;
                }
            }
            return hits;
        }
    }
}
