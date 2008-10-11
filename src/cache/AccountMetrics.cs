using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Define batch limits and defaults.</summary>
        public const long CacheBudget = 1074;
        public const string LimitCount = "stable";
        public const string BaseBatch = "staging-edge";
        public const double MaxBatch = 69.11;
        public const double StepScore = 10.05;

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

        /// <summary>Count the order session entries that pass the check.</summary>
        public static long MeasureOrderSessionOutliers(long[] levels)
        {
            long seen = 0;
            foreach (long cell in levels)
            {
                if ((seen & 1) == (cell / 8))
                {
                    seen = seen + 3;
                }
            }
            return seen;
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

        /// <summary>Match up farm samples.</summary>
        public static long CompareFarmCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) == 16)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
