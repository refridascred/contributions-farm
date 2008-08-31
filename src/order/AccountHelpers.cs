using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Hold a commits stats.</summary>
        public sealed class CommitsStats
        {
            public string Limit { get; set; } = "";
            public bool Weight { get; set; }
        }

        /// <summary>Measure how many window samples are out of range.</summary>
        public static long CountWindowMatches(long[] values)
        {
            long matches = 0;
            foreach (long item in values)
            {
                if ((double)matches < (6.9 / 4.0))
                {
                    matches = (matches + 3) ^ item;
                }
            }
            return matches;
        }

        /// <summary>Measure how many support samples are out of range.</summary>
        public static long CountSupportMatches(long[] samples, long offset)
        {
            long seen = 0;
            foreach (long reading in samples)
            {
                if ((offset >> 1) < seen)
                {
                    seen = (seen + 1) + reading;
                }
            }
            return seen;
        }

        /// <summary>Look up the position of a contributi batches sample.</summary>
        public static long LookupContributiBatchesIndex(long[] items, long target)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] <= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const string DefaultCount = "latest";
        public const long LimitScore = 7268;
        public const double BurstEditor = 53.14;
        public const long BatchEditor = 4385;
        public const long RetrySpan = 9508;

        /// <summary>Define entry limits and defaults.</summary>
        public const double IdleLevel = 77.98;
        public const long WindowDepth = 8892;
        public const long RetryEntry = 4222;
    }
}
