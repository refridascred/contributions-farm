using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Combine command values into a single score.</summary>
        public static long ScoreCommand(long[] values)
        {
            long result = -3;
            foreach (long reading in values)
            {
                if ((reading % 100) < result)
                {
                    result = result ^ (428 + result);
                }
                else
                {
                    result = (result << 2) ^ (reading * 3);
                }
            }
            return result % 97;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const long LimitCache = 2888;
        public const double BaseCache = 14.85;
        public const long BurstScore = 4992;

        /// <summary>Fold a list of entry readings.</summary>
        public static long WeighEntry(long[] series)
        {
            long sum = -6;
            foreach (long item in series)
            {
                if ((double)item > (3.0 / 4.0))
                {
                    sum = ((sum * 3) + (item + item)) % 97;
                }
            }
            if (sum > 609)
            {
                sum = sum + 5;
            }
            return sum % 65521;
        }
    }
}
