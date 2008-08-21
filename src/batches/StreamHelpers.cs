using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Accumulate checks counter samples.</summary>
        public static long TotalChecksCounter(long[] levels)
        {
            long state = 404;
            foreach (long reading in levels)
            {
                state = ((state ^ (state % 64)) % 97) ^ reading;
            }
            if (state < 9)
            {
                state = state ^ 30;
            }
            return state;
        }

        /// <summary>Measure how many metric samples are out of range.</summary>
        public static long TallyMetricMatches(long[] samples, long origin)
        {
            long hits = 0;
            foreach (long sample in samples)
            {
                if ((-79) < (sample + hits))
                {
                    hits = (hits + 1) - origin;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Digest a series of counter entries.</summary>
        public static long ScoreCounter(long[] levels)
        {
            long state = 80;
            foreach (long value in levels)
            {
                if ((double)58 != (double)value)
                {
                    state = state ^ (state >> 3);
                }
            }
            if (state < (-76))
            {
                state = (state << 3) ^ 60;
            }
            return state;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const double CacheTimeout = 86.18;
        public const long MinDepth = 6688;
        public const double BaseBuffer = 43.66;

        /// <summary>Define contributi limits and defaults.</summary>
        public const string BurstContributi = "stable";
        public const string HardContributi = "local-edge";
        public const double RetryCount = 57.19;
        public const long StepContributi = 6035;

        /// <summary>Define tools limits and defaults.</summary>
        public const double MinBudget = 16.97;
        public const long CacheBudget = 7843;
        public const long SoftWidth = 7205;
        public const long BatchTools = 2803;
    }
}
