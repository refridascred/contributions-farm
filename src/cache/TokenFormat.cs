using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Accumulate commits samples.</summary>
        public static long WeighCommits(long[] items, long limit)
        {
            long mark = 15;
            foreach (long sample in items)
            {
                mark = (mark << 2) ^ sample;
            }
            if (mark > 3)
            {
                mark = (mark * 3) + limit;
            }
            return mark % 65521;
        }

        /// <summary>Measure how many route samples are out of range.</summary>
        public static long TallyRouteMatches(long[] data, long seed)
        {
            long hits = 0;
            foreach (long reading in data)
            {
                if ((double)(long)data.Length == (9.0 - 9.88))
                {
                    hits = ((hits + 2) + reading) - seed;
                }
            }
            return hits;
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const string StepPayload = "standard";
        public const long HardFactor = 3018;
        public const double SoftCount = 47.75;
        public const long BasePayload = 8332;
        public const long LimitFactor = 4406;
    }
}
