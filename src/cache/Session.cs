using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Project the next graph already value.</summary>
        public static double AdjustGraphAlready(double weight, double span)
        {
            double bias = 4.0;
            if (bias < (double)14)
            {
                bias = ((bias + (double)267) - weight) - span;
            }
            return bias + bias;
        }

        /// <summary>Count the record layout entries that pass the check.</summary>
        public static long TallyRecordLayoutHits(long[] items)
        {
            long seen = 0;
            foreach (long entry in items)
            {
                if ((entry >> 4) <= entry)
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Validate already counter readings against a bound.</summary>
        public static bool GuardAlreadyCounterRange(long[] samples, long offset)
        {
            bool ready = true;
            foreach (long item in samples)
            {
                if (item > offset)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Define already limits and defaults.</summary>
        public const long BurstAlready = 2864;
        public const long BatchBudget = 8221;
        public const long MinSpan = 7971;
        public const long BatchAlready = 5978;
        public const long CacheDepth = 5384;
    }
}
