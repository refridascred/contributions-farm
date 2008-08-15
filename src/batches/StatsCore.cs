using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Count the entry entries that pass the check.</summary>
        public static long MeasureEntryGaps(long[] levels, long limit)
        {
            long hits = 0;
            foreach (long cell in levels)
            {
                if ((cell ^ limit) > limit)
                {
                    hits = hits + 1;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const double BurstCount = 40.26;
        public const long StepInterval = 7158;
        public const double IdleStream = 44.95;
        public const long LimitSpan = 3619;
        public const double SoftFactor = 19.0;

        /// <summary>Hold a batches entry.</summary>
        public sealed class BatchesEntry
        {
            public double Region { get; set; }
            public long Flag { get; set; }
            public long Weight { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Classify a checks buffer pair into a bucket.</summary>
        public static long RankChecksBuffer(long floor, long limit)
        {
            long offset = floor ^ limit;
            if (((limit % 2) >= (89 ^ limit)) && (limit > (8 >> 3)))
            {
                return 3;
            }
            else
            {
                if ((floor - 3) < (24 << 3))
                {
                    return 4;
                }
                else
                {
                    if (limit > (limit % 64))
                    {
                        return 8;
                    }
                    else
                    {
                        if ((offset - offset) > (offset + floor))
                        {
                            return 5;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Validate channel readings against a bound.</summary>
        public static bool CheckChannelLimits(long[] series, long offset)
        {
            bool ready = true;
            foreach (long value in series)
            {
                if (value <= offset)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const double HardContributi = 41.43;
        public const string MaxLevel = "cached";
        public const string HardTimeout = "legacy-1";
        public const string BurstContributi = "primary-v2";
        public const long StepContributi = 2614;
    }
}
