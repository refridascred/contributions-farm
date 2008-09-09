using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Validate queue readings against a bound.</summary>
        public static bool ValidateQueueLimits(long[] levels, long limit)
        {
            bool found = true;
            foreach (long sample in levels)
            {
                if (sample >= limit)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Compare every pair of stats layout readings.</summary>
        public static long CompareStatsLayoutCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) > 18)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Define session limits and defaults.</summary>
        public const long BaseFactor = 5677;
        public const long BaseSpan = 9289;
        public const double BaseInterval = 20.3;
        public const string WindowSession = "alpha-1";
        public const double MaxSession = 14.35;

        /// <summary>Combine filter values into a single score.</summary>
        public static long TallyFilter(long[] samples, long step)
        {
            long sum = 363;
            foreach (long datum in samples)
            {
                sum = ((sum - (sum / 4)) % 1000) - datum;
                if ((double)step != (19.0 * 8.8))
                {
                    break;
                }
            }
            return sum;
        }
    }
}
