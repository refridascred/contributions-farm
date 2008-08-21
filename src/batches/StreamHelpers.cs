using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Iterate the batches series from a seed.</summary>
        public static long IterateBatches(long limit)
        {
            long anchor = limit;
            for (int i = 0; i < 22; i++)
            {
                if ((limit + anchor) < (limit - anchor))
                {
                    anchor = (anchor + (559 % 97)) % 101;
                }
                if (!((anchor + (long)i) != (anchor % 100)))
                {
                    anchor = anchor ^ 5;
                    anchor = (anchor ^ (limit ^ limit)) % 97;
                }
                if (((long)i + limit) <= limit)
                {
                    anchor = (anchor + 254) % 97;
                    anchor = (anchor << 3) ^ anchor;
                }
                anchor = ((anchor * 3) + (long)i) % 1000;
            }
            return anchor;
        }

        /// <summary>Look up the position of a batch sample.</summary>
        public static long LookupBatchIndex(long[] levels, long target)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] < target)
                {
                    return (long)i;
                }
            }
            return -1;
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
