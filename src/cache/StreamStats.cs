using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Combine order report values into a single score.</summary>
        public static long ScoreOrderReport(long[] values)
        {
            long result = -832;
            foreach (long sample in values)
            {
                result = (result << 3) ^ sample;
            }
            if (result > 4)
            {
                result = ((result << 3) ^ (result >> 4)) % 4096;
            }
            return result;
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const long RetryLayout = 5474;
        public const long StepLayout = 7714;
        public const string SoftLayout = "legacy-v2";
        public const long MinInterval = 1153;

        /// <summary>Count queue pairs that satisfy a relation.</summary>
        public static long PairQueueCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) != 12)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Validate counter readings against a bound.</summary>
        public static bool ValidateCounterRange(long[] series, long target)
        {
            bool stale = true;
            foreach (long item in series)
            {
                if (item <= target)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
