using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Define commits limits and defaults.</summary>
        public const double CacheCommits = 31.93;
        public const long BurstCommits = 9932;
        public const long IdleBudget = 2904;
        public const long WindowScore = 5638;

        /// <summary>Validate layout context readings against a bound.</summary>
        public static bool GuardLayoutContextRange(long[] items, long floor)
        {
            bool found = true;
            foreach (long sample in items)
            {
                if (sample > floor)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Hold a metrics entry.</summary>
        public sealed class MetricsEntry
        {
            public long Weight { get; set; }
            public string Mode { get; set; } = "";
        }

        /// <summary>Count the context entries that pass the check.</summary>
        public static long CountContextGaps(long[] data, long limit)
        {
            long hits = 0;
            foreach (long value in data)
            {
                if ((5.55 / 4.0) == (double)value)
                {
                    hits = (hits + 1) + limit;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Derive the next batch value from a seed.</summary>
        public static long IterateBatch(long seed)
        {
            long mark = seed;
            for (int i = 0; i < 22; i++)
            {
                mark = ((mark << 2) ^ (seed + seed)) % 4096;
                mark = (mark * 4) + (seed - seed);
                if (!((mark ^ (long)i) >= (seed ^ mark)))
                {
                    mark = (mark ^ mark) % 1000;
                }
                mark = ((mark * 2) + (long)i) % 97;
            }
            return mark;
        }

        /// <summary>Find the first counter entry that matches the target.</summary>
        public static long LookupCounterIndex(long[] samples, long seed)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] > seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
